﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.DataSourcesFile;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.SystemUI;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Display;
using System.Drawing.Text;
using stdole;
using DevComponents.DotNetBar;
using AOFunctions.GDB;
using ESRI.ArcGIS.Output;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using DevExpress.Pdf;
using DevExpress.Pdf.Drawing;
using DevExpress.XtraCharts;
using DataAlignment;

namespace LibCerMap
{
    public partial class FrmGeneratePDFReport : OfficeForm
    {
        //点图层的投影信息
        ISpatialReference psf = null;

        IMapControl3 pMapcontrol;
        IPageLayoutControl pPageLayoutControl;

        public FrmGeneratePDFReport(IMapControl3 mapcontrol, IPageLayoutControl pagelayoutcontrol)
        {
            InitializeComponent();
            this.EnableGlass = false;
            pMapcontrol = mapcontrol;
            pPageLayoutControl = pagelayoutcontrol;
        }

        private void FrmPointToLine_Load(object sender, EventArgs e)            
        {            
            for (int i = 0; i < pMapcontrol.LayerCount; i++)
            {
                ILayer pLayer = null;
                if (pMapcontrol.get_Layer(i) is IFeatureLayer)
                {
                    pLayer = pMapcontrol.get_Layer(i);
                    IFeatureLayer pFeatureLayer = pLayer as IFeatureLayer;
                    IFeatureClass pFeatureClass = pFeatureLayer.FeatureClass;
                    if (pFeatureClass.ShapeType == esriGeometryType.esriGeometryPoint || pFeatureClass.ShapeType == esriGeometryType.esriGeometryMultipoint)
                    {
                        cboBoxPointLayer.Items.Add(pLayer.Name);
                    }
                    if (pFeatureClass.ShapeType == esriGeometryType.esriGeometryPoint || pFeatureClass.ShapeType == esriGeometryType.esriGeometryMultipoint)
                    {
                        comboBoxExIMULayer.Items.Add(pLayer.Name);
                    }
                    if (pFeatureClass.ShapeType == esriGeometryType.esriGeometryPolyline)
                    {
                        comboBoxExCenterline.Items.Add(pLayer.Name);
                    }
                }
            }
            if (cboBoxPointLayer.Items.Count > 0)
            {
                cboBoxPointLayer.SelectedIndex = 0;
            }
            if (comboBoxExIMULayer.Items.Count > 0)
            {
                comboBoxExIMULayer.SelectedIndex = 0;
            }
            if (comboBoxExCenterline.Items.Count > 0)
            {
                comboBoxExCenterline.SelectedIndex = 0;
            }
            labelNeirong.Font = new System.Drawing.Font("仿宋", 4F);
            labelbiaotou.Font = new System.Drawing.Font("仿宋", 6F);
        }

        //添加点图层按钮
        private void btAddPoint_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFile = new OpenFileDialog();
            OpenFile.Title = "添加点图层";
            OpenFile.Filter = "(*.shp)|*.shp";
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                cboBoxPointLayer.Items.Add(System.IO.Path.GetFileNameWithoutExtension(OpenFile.FileName));

                try
                {
                    //获得文件路径
                    string filePath = System.IO.Path.GetDirectoryName(OpenFile.FileName);
                    //获得文件名称
                    string fileNam = System.IO.Path.GetFileName(OpenFile.FileName);
                    //加载shape文件
                    pMapcontrol.AddShapeFile(filePath, fileNam);
                    pMapcontrol.Refresh();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                cboBoxPointLayer.SelectedIndex = 0;
            }
        }

        //保存线文件
        private void btAddLine_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveFile = new SaveFileDialog();
            SaveFile.Title = "输入保存文件路径及名称";
            SaveFile.Filter = "(*.shp)|*.shp";
            if (SaveFile.ShowDialog() == DialogResult.OK)
            {
                //    txtLineFilePath.Text = SaveFile.FileName;
            }
        }

        private void btOK_Click(object sender, EventArgs e)
        {

            try
            {
                string outFile = "";

                SaveFileDialog dlg = new SaveFileDialog();
                dlg.Filter = "PDF files (*.pdf)|*.pdf";
                if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    outFile = dlg.FileName;
                }
                else
                {
                    return;
                }
                double begm = 0; double endm = 0;
                GetCenterlineBeginEndMeasure(ref begm, ref endm);
                if (radioButtonWholeCenterline.Checked)
                {
                    GenerateReportOfSegment(begm, endm, outFile);
                }
                if (radioButtonGivenBeginEndMeasure.Checked)
                {
                    double bm = Convert.ToDouble(numericUpDownBeginMeasure1.Value);
                    double em = Convert.ToDouble(numericUpDownEndMeasure1.Value);
                    GenerateReportOfSegment(bm, em, outFile);
                }
                if (radioButtonSelectRangeOnMap.Checked)
                {

                }
                if (radioButtonMuliple.Checked)
                {
                    double bm = Convert.ToDouble(numericUpDownBeginMeasure2.Value);
                    double em = Convert.ToDouble(numericUpDownEndMeasure2.Value);
                    double tempB = bm;
                    double tempE = tempB + Convert.ToDouble(numericUpDownSegmentLength.Value);
                    GenerateReportOfSegment(tempB, tempE, outFile);
                    tempB = tempE;
                    int i = 1;
                    while (tempB < em)
                    {
                        tempE = tempB + Convert.ToDouble(numericUpDownSegmentLength.Value);
                        if (tempE >= em)
                        {
                            tempE = em;
                        }
                        GenerateReportOfSegment(tempB, tempE, outFile.Substring(0, outFile.Length - 4) + "_" + i.ToString() + ".pdf");
                        tempB = tempE;
                        i++;
                    }

                }


                MessageBox.Show("导出成功");
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void GetCenterlineBeginEndMeasure(ref double beginM, ref double endM)
        {
            string pPointFileName = cboBoxPointLayer.SelectedItem.ToString();
            IFeatureLayer pCenterlinePointLayer = null;
            for (int i = 0; i < pMapcontrol.LayerCount; i++)
            {
                if (pPointFileName == pMapcontrol.get_Layer(i).Name)
                {
                    pCenterlinePointLayer = pMapcontrol.get_Layer(i) as IFeatureLayer;
                }
            }
            IFeatureClass pPointFC = pCenterlinePointLayer.FeatureClass;
            IQueryFilter pQF = null;
            DataTable alignmentPointTable = AOFunctions.GDB.ITableUtil.GetDataTableFromITable(pPointFC as ITable, pQF);
            DataView dv = alignmentPointTable.DefaultView;
            // dv.Sort = "里程（m）" + " ASC";
            dv.Sort = EvConfig.CenterlineMeasureField + " ASC";

            alignmentPointTable = dv.ToTable();
            beginM = Convert.ToDouble(alignmentPointTable.Rows[0][EvConfig.CenterlineMeasureField]);
            endM = Convert.ToDouble(alignmentPointTable.Rows[alignmentPointTable.Rows.Count - 1][EvConfig.CenterlineMeasureField]);

        }
        private List<Tuple<double, string>> GetPDFBandData(string fieldName)
        {
            List<Tuple<double, string>> banddata = new List<Tuple<double, string>>();

            string pPointFileName = comboBoxExIMULayer.SelectedItem.ToString();
            IFeatureLayer pIMUPointLayer = null;
            for (int i = 0; i < pMapcontrol.LayerCount; i++)
            {
                if (pPointFileName == pMapcontrol.get_Layer(i).Name)
                {
                    pIMUPointLayer = pMapcontrol.get_Layer(i) as IFeatureLayer;
                }
            }
            IFeatureClass pPointFC = pIMUPointLayer.FeatureClass;
            IQueryFilter pQF = null;
            DataTable alignmentPointTable = AOFunctions.GDB.ITableUtil.GetDataTableFromITable(pPointFC as ITable, pQF);

            var query = (from r in alignmentPointTable.AsEnumerable()
                         where r["类型"].ToString().Contains("异常")
                         select r).ToList();
            foreach (DataRow r in query)
            {
                banddata.Add(new Tuple<double, string>(Convert.ToDouble(r["对齐里程"]), r[fieldName].ToString()));
            }
            return banddata;
        }

        private void GenerateReportOfSegment(double BegMeasure, double endMeasure, string outFile)
        {
            if (checkBoxRotateMap.Checked)
            {
                IFeatureLayer pCenterlineLayer = null;
                string pCenterlineFileName = comboBoxExCenterline.SelectedItem.ToString();
                for (int i = 0; i < pMapcontrol.LayerCount; i++)
                {
                    if (pCenterlineFileName == pMapcontrol.get_Layer(i).Name)
                    {
                        pCenterlineLayer = pMapcontrol.get_Layer(i) as IFeatureLayer;
                    }
                }
                IFeatureClass pCenterlineFC = pCenterlineLayer.FeatureClass;
                try
                {
                    IFeatureCursor pCurcor = pCenterlineFC.Search(null, false);
                    IFeature pFeature = pCurcor.NextFeature();
                    IGeometry pGeo = pFeature.Shape;
                    IMSegmentation pMS = pGeo as IMSegmentation;
                    double minM = pMS.MMin;
                    double maxM = pMS.MMax;
                    BegMeasure = BegMeasure < minM ? minM : BegMeasure;
                    endMeasure = endMeasure > maxM ? maxM : endMeasure;
                    IPoint begPt = pMS.GetPointsAtM(BegMeasure, 0).Geometry[0] as IPoint;
                    IPoint endPt = pMS.GetPointsAtM(endMeasure, 0).Geometry[0] as IPoint;

                    ISpatialReference sourcePrj;
                    sourcePrj = pCenterlineFC.Fields.get_Field(pCenterlineFC.FindField(pCenterlineFC.ShapeFieldName)).GeometryDef.SpatialReference;
                    ISpatialReference targetPrj = pMapcontrol.Map.SpatialReference;
                    IPoint begPtPrj;
                    IPoint endPtPrj;
                    begPt.Project(targetPrj);
                    endPt.Project(targetPrj);
                    begPtPrj = begPt;
                    endPtPrj = endPt;
                    IActiveView pView = this.pMapcontrol.Map as IActiveView;
                    pView.ScreenDisplay.DisplayTransformation.Rotation = 0;
                    double widthHeightR = (((double)pView.ExportFrame.right - pView.ExportFrame.left) / ((double)pView.ExportFrame.bottom - pView.ExportFrame.top));
                    // Dim fw As New FileWindow(begPt, endPt, widthHeightR)
                    MCenterlineUtil fw = new MCenterlineUtil(begPtPrj, endPtPrj, widthHeightR);

                    fw.FitActiveViewTo(pView, true);

                    System.Runtime.InteropServices.Marshal.ReleaseComObject(pCurcor);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }


            #region //导出arcmap 地图 export mapfram

            IPageLayout _PageLayout = this.pPageLayoutControl.PageLayout;
            SizeF m_PageSize = new SizeF();
            double width;
            double hight;



            _PageLayout.Page.QuerySize(out width, out hight);
            m_PageSize.Width = Convert.ToSingle(width);
            m_PageSize.Height = Convert.ToSingle(hight);
            IUnitConverter pUConvert = new UnitConverterClass();
            esriUnits ut = _PageLayout.Page.Units;
            float pageUnitToInchUnitScale = (float)pUConvert.ConvertUnits(1, ut, esriUnits.esriInches);



            var layerOutPageSize = m_PageSize;
            var outputDPI = 300;
            int BandHeadWidth = 40;

            var originalActiveView = _PageLayout as IActiveView;
            var activeView = _PageLayout as IActiveView;
            originalActiveView.Refresh();
            var avEvents = _PageLayout as IActiveViewEvents;

            float centerX = layerOutPageSize.Width / 2;
            float centerY = layerOutPageSize.Height / 2;

            var backGroundEnv = new Envelope() as IEnvelope;
            backGroundEnv.PutCoords(0, 0, layerOutPageSize.Width, layerOutPageSize.Height);

            activeView.Extent = backGroundEnv;
            //System.Threading.Thread.Sleep(2000);

            IExport pExporter = new ExportPDF() as IExport;
            pExporter.ExportFileName = outFile;
            pExporter.Resolution = outputDPI;

            var pExPdf = pExporter as IExportPDF;
            pExPdf.Compressed = true;
            pExPdf.ImageCompression = esriExportImageCompression.esriExportImageCompressionDeflate;

            var screenResolution = GetCurrentScreenResolution();
            var outputResolution = outputDPI;

            ESRI.ArcGIS.esriSystem.tagRECT exportRECT;
            exportRECT.left = 0;
            exportRECT.top = 0;
            exportRECT.right = (int)(activeView.ExportFrame.right * outputResolution / screenResolution) + 1;
            exportRECT.bottom = (int)(activeView.ExportFrame.bottom * outputResolution / screenResolution) + 1;

            var envelope = new Envelope() as IEnvelope;
            envelope.PutCoords(exportRECT.left, exportRECT.top, exportRECT.right, exportRECT.bottom);
            pExporter.PixelBounds = envelope;

            var hDC = pExporter.StartExporting();
            activeView.Output(hDC, outputDPI, exportRECT, backGroundEnv, null);

            pExporter.FinishExporting();
            pExporter.Cleanup();
            // MessageBox.Show("Export finished.");
            #endregion

            #region  //根据中线图层生成剖面图
            System.Drawing.Point LastBottomLeftPoint = new System.Drawing.Point();
            int bandwidth = 0;
            PdfGraphics pGraphics = null;

            IFeatureLayer pCenterlinePointLayer = null;
            string centerlinePointnName = cboBoxPointLayer.SelectedItem.ToString();

            for (int i = 0; i < pMapcontrol.LayerCount; i++)
            {
                if (centerlinePointnName == pMapcontrol.get_Layer(i).Name)
                {
                    pCenterlinePointLayer = pMapcontrol.get_Layer(i) as IFeatureLayer;
                }
            }
            IQueryFilter pQF = null;
            DataTable centerlinePointTable = AOFunctions.GDB.ITableUtil.GetDataTableFromITable(pCenterlinePointLayer.FeatureClass as ITable, pQF);
            chartControl1.Series.Clear();
            Series series = new Series("高程", ViewType.Line);
            Series series2 = new Series("埋深", ViewType.Line);
            SecondaryAxisY myAxisY = new SecondaryAxisY("埋深");

            foreach (DataRow r in centerlinePointTable.Rows)
            {
                double m; double z; double underz;
                m = Convert.ToDouble(r[EvConfig.CenterlineMeasureField]);
                if (m < BegMeasure || m > endMeasure)
                    continue;
                if (r[EvConfig.CenterlineMeasureField] != DBNull.Value && r[EvConfig.CenterlineZField] != DBNull.Value)
                {
                    m = Convert.ToDouble(r[EvConfig.CenterlineMeasureField]);
                    z = Convert.ToDouble(r[EvConfig.CenterlineZField]);
                    series.Points.Add(new SeriesPoint(m, z));
                }
                // if (r[EvConfig.CenterlineMeasureField] != DBNull.Value && r["管道埋深（"] != DBNull.Value)
                if (r[EvConfig.CenterlineMeasureField] != DBNull.Value && r[EvConfig.CenterlineBuryDepthField] != DBNull.Value)
                {
                    m = Convert.ToDouble(r[EvConfig.CenterlineMeasureField]);
                    z = Convert.ToDouble(r[EvConfig.CenterlineBuryDepthField]);
                    series2.Points.Add(new SeriesPoint(m, z));
                }
            }

            chartControl1.Series.Add(series);
            chartControl1.Series.Add(series2);
            ((XYDiagram)chartControl1.Diagram).SecondaryAxesY.Clear();
            ((XYDiagram)chartControl1.Diagram).SecondaryAxesX.Clear();
            ((XYDiagram)chartControl1.Diagram).SecondaryAxesY.Add(myAxisY);
            ((LineSeriesView)series2.View).AxisY = myAxisY;
            ((LineSeriesView)series.View).AxisY = ((XYDiagram)chartControl1.Diagram).AxisY;
            series.ChangeView(ViewType.Line);
            ((XYDiagram)chartControl1.Diagram).AxisY.WholeRange.Auto = true;
            myAxisY.WholeRange.Auto = true;
            series2.ChangeView(ViewType.Line);
            myAxisY.Tickmarks.Visible = true;
            myAxisY.Tickmarks.MinorVisible = false;
            ((XYDiagram)chartControl1.Diagram).AxisX.WholeRange.AutoSideMargins = false;
            ((XYDiagram)chartControl1.Diagram).AxisX.WholeRange.SideMarginsValue = 0;
            ((XYDiagram)chartControl1.Diagram).AxisX.WholeRange.SetMinMaxValues(BegMeasure, endMeasure);
            series.ArgumentScaleType = ScaleType.Numerical;

            int ProfileMapHight = 8;

            #endregion
            

            #region export chartcontrol
            IGraphicsContainer pGC = _PageLayout as IGraphicsContainer;
            pGC.Reset();
            IElement pE = pGC.Next();
            while (pE != null)
            {
                if (pE is IMapFrame)
                {
                    // framgeo related to _PageLayout.Page pagesize, 8.5 x 11, inch
                    IEnvelope framgeo = pE.Geometry.Envelope as IEnvelope;
                    float defaultDPI = PdfGraphics.DefaultDpi;
                    double x = defaultDPI * framgeo.LowerLeft.X * pageUnitToInchUnitScale;
                    double y = defaultDPI * (layerOutPageSize.Height - framgeo.LowerLeft.Y) * pageUnitToInchUnitScale + 1;

                    bandwidth = (int)(defaultDPI * (framgeo.Width * pageUnitToInchUnitScale));

                    LastBottomLeftPoint.X = (int)x;
                    LastBottomLeftPoint.Y = (int)y;

                    chartControl1.Size = new System.Drawing.Size((int)(framgeo.Width * pageUnitToInchUnitScale * defaultDPI), (int)(ProfileMapHight * pageUnitToInchUnitScale * defaultDPI));

                    Image img = null;
                    Bitmap bmp = null;
                    // Create an image of the chart.
                    ImageFormat format = ImageFormat.Png;
                    using (MemoryStream s = new MemoryStream())
                    {
                        chartControl1.ExportToImage(s, format);
                        img = Image.FromStream(s);
                        bmp = new Bitmap(img);
                        bmp.SetResolution(300, 300);
                    }

                    using (PdfDocumentProcessor processor = new PdfDocumentProcessor())
                    {
                        processor.LoadDocument(outFile);
                        PdfDocument pd = processor.Document;
                        PdfPage page = pd.Pages[0];
                        PdfRectangle pdfrec = page.MediaBox;
                        // RectangleF rf = new RectangleF(0, 0, Convert.ToSingle(pdfrec.Width) * 96 / 72, Convert.ToSingle(pdfrec.Height) * 96 / 72);
                        // Create and draw PDF graphics.
                        using (pGraphics = processor.CreateGraphics())
                        {
                            PdfGraphics graph = pGraphics;

                            Pen defaultPen = new Pen(Color.Black);
                            defaultPen.Width = 1;
                            graph.DrawImage(bmp, new RectangleF((float)x, (float)y, (float)framgeo.Width * pageUnitToInchUnitScale * defaultDPI, (float)ProfileMapHight * pageUnitToInchUnitScale * defaultDPI));

                            // draw map head.
                            RectangleF MapheadRect = new RectangleF((float)(int)(defaultDPI * framgeo.XMin * pageUnitToInchUnitScale - BandHeadWidth),
                                (float)(int)(defaultDPI * (layerOutPageSize.Height - framgeo.UpperLeft.Y) * pageUnitToInchUnitScale),
                               (float)(int)(BandHeadWidth),
                               (float)(int)(defaultDPI * framgeo.Height * pageUnitToInchUnitScale));
                            graph.DrawRectangle(defaultPen, MapheadRect);
                            //draw head text
                            RectangleF rF = new RectangleF(0, 0, (float)MapheadRect.Height, (float)BandHeadWidth);
                            PdfStringFormat psf = new PdfStringFormat(PdfStringFormat.GenericDefault);
                            psf.Alignment = PdfStringAlignment.Center;
                            psf.LineAlignment = PdfStringAlignment.Center;
                            graph.SaveGraphicsState();
                            // head box 的左下角
                            System.Drawing.Font textfont = new System.Drawing.Font("仿宋", 6F);
                            graph.TranslateTransform((float)(MapheadRect.Left), (float)(MapheadRect.Bottom));
                            graph.RotateTransform(270);
                            graph.DrawString("地图", textfont, new SolidBrush(Color.Black), rF, psf);
                            graph.RestoreGraphicsState();

                            
                            // draw chart head
                            RectangleF ChartheadRect = new RectangleF((float)(int)(defaultDPI * framgeo.XMin * pageUnitToInchUnitScale - BandHeadWidth),
                              (float)(int)(defaultDPI * (layerOutPageSize.Height - framgeo.LowerLeft.Y) * pageUnitToInchUnitScale + 1),
                             (float)(int)(BandHeadWidth),
                             (float)(int)(defaultDPI * ProfileMapHight * pageUnitToInchUnitScale));
                            graph.DrawRectangle(defaultPen, ChartheadRect);
                            //draw head text
                            rF = new RectangleF(0, 0, (float)ChartheadRect.Height, (float)BandHeadWidth);
                            graph.SaveGraphicsState();
                            // head box 的左下角                           
                            graph.TranslateTransform((float)(ChartheadRect.Left), (float)(ChartheadRect.Bottom));
                            graph.RotateTransform(270);
                            graph.DrawString("剖面图", textfont, new SolidBrush(Color.Black), rF, psf);
                            graph.RestoreGraphicsState();


                            LastBottomLeftPoint.Y = (int)ChartheadRect.Bottom;
                            //double beginM = -999; double endM = -999;
                            //GetIMUBeginEndMeasure(ref beginM, ref endM);
                            double beginM = BegMeasure;
                            double endM = endMeasure;
                            for (int i = 0; i < listBoxDrawBandFields.Items.Count; i++)
                            {
                                string fieldname = listBoxDrawBandFields.Items[i].ToString();
                                band b = new band();
                                b.BandName = fieldname;
                                b.pdfGC = pGraphics;
                                b.BandWidth = (int)bandwidth;
                                b.headFont = labelbiaotou.Font;
                                b.ContentFont = labelNeirong.Font;
                                System.Drawing.Point pt = new System.Drawing.Point();
                                pt.X = LastBottomLeftPoint.X;
                                pt.Y = LastBottomLeftPoint.Y;
                                b.BandTopLeftLocation = pt;

                                b.BeginM = beginM;
                                b.EndM = endM;
                                //b.bandData = new List<Tuple<double, string>>();
                                //for (int j = 0; j < 6; j++)
                                //{
                                //    double m = j * 500;
                                //    string txt = "异常2";
                                //    Tuple<double, string> t = new Tuple<double, string>(m,txt);
                                //    b.bandData.Add(t);
                                //}
                                b.bandData = GetPDFBandData(fieldname);
                                b.Draw();
                                LastBottomLeftPoint.Y += (int)b.BandHight;
                            }
                            // graph.DrawImage(img, rf);
                            graph.AddToPageForeground(page);
                            // Render a page with graphics.
                            //processor.RenderNewPage(PdfPaperSize.Letter, graph);
                            processor.SaveDocument(outFile);
                        }
                    }
                    break;
                }
                pE = pGC.Next();

            }
            #endregion
        }

        [DllImport("GDI32.dll", EntryPoint = "GetDeviceCaps", ExactSpelling = true, SetLastError = true)]
        public static extern int GetDeviceCaps(IntPtr hdc, int nIndex);
        private int GetCurrentScreenResolution()
        {
            try
            {
                var g = Graphics.FromHwnd(IntPtr.Zero);
                var desktop = g.GetHdc();
                int dpi = GetDeviceCaps(desktop, 88);  //90 Y 
                return dpi;
            }
            catch (Exception ex)
            {
                return 96;
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxExIMULayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxFields.Items.Clear();
            listBoxDrawBandFields.Items.Clear();
            string pPointFileName = comboBoxExIMULayer.SelectedItem.ToString();
            IFeatureLayer pIMUPointLayer = null;
            for (int i = 0; i < pMapcontrol.LayerCount; i++)
            {
                if (pPointFileName == pMapcontrol.get_Layer(i).Name)
                {
                    pIMUPointLayer = pMapcontrol.get_Layer(i) as IFeatureLayer;
                }
            }
            IFeatureClass pPointFC = pIMUPointLayer.FeatureClass;
            for (int i = 0; i < pPointFC.Fields.FieldCount; i++)
            {
                IField fd = pPointFC.Fields.get_Field(i);
                // if (fd.Type == esriFieldType.esriFieldTypeDouble)
                {
                    listBoxFields.Items.Add(fd.Name);
                }
            }
        }

        private void buttonXRemove_Click(object sender, EventArgs e)
        {
            if (listBoxDrawBandFields.SelectedIndex < 0)
            {
                return;
            }
            else
            {
                int idx = listBoxDrawBandFields.SelectedIndex;
                listBoxFields.Items.Add(listBoxDrawBandFields.Items[idx].ToString());

                string pPointFileName = comboBoxExIMULayer.SelectedItem.ToString();
                //IFeatureLayer pIMUPointLayer = null;
                //for (int i = 0; i < pMapcontrol.LayerCount; i++)
                //{
                //    if (pPointFileName == pMapcontrol.get_Layer(i).Name)
                //    {
                //        pIMUPointLayer = pMapcontrol.get_Layer(i) as IFeatureLayer;
                //    }
                //}
                //IFeatureClass pPointFC = pIMUPointLayer.FeatureClass;
                //int insertidx = pPointFC.Fields.FindField(listBoxDrawBandFields.Items[idx].ToString());
                //if (insertidx > 0)
                //{
                //    listBoxFields.Items.Insert(insertidx,listBoxDrawBandFields.Items[idx].ToString());                   
                //}
                listBoxDrawBandFields.Items.RemoveAt(idx);

            }
        }

        private void buttonXAdd_Click(object sender, EventArgs e)
        {
            if (listBoxFields.SelectedIndex < 0)
                return;
            else
            {
                int idx = listBoxFields.SelectedIndex;
                listBoxDrawBandFields.Items.Add(listBoxFields.Items[idx].ToString());
                listBoxFields.Items.RemoveAt(idx);
            }
        }

        private void cboBoxPointLayer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxFields_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            buttonXAdd_Click(null, null);
        }

        private void listBoxDrawBandFields_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            buttonXRemove_Click(null, null);
        }

        private void chartControl1_CustomDrawAxisLabel(object sender, CustomDrawAxisLabelEventArgs e)
        {
            if (e.Item.Axis.Equals(((XYDiagram)chartControl1.Diagram).AxisX))
            {

            }
            else
            {
                //TextAnnotation ann = chartControl1.Annotations.AddTextAnnotation();
                //ann.Text = e.Item.Text;
                //PaneAnchorPoint spa = new PaneAnchorPoint();
                //spa.AxisXCoordinate.Axis = ((XYDiagram)chartControl1.Diagram).AxisX;
                //spa.AxisYCoordinate.Axis = ((XYDiagram)chartControl1.Diagram).AxisY;
                //spa.AxisXCoordinate.AxisValue = 0;
                //spa.AxisYCoordinate.AxisValue = e.Item.AxisValue;
                //RelativePosition pos = new RelativePosition();
                //pos.Angle = 0;
                //pos.ConnectorLength = 20;
                //ann.ShapePosition = pos;
                //ann.AnchorPoint = spa;
                
                e.Item.Text = null;
                



                // ((XYDiagram)chartControl1.Diagram).AxisY.Label.
                //foreach (SeriesPoint sp in chart.Diagram.Series[0].Points)
                //{
                //    Annotation ann = new Annotation();
                //    ann.Content = string.Format("{0:N0}", sp.Value);
                //    PaneAnchorPoint spa = new PaneAnchorPoint();
                //    spa.AxisXCoordinate = new AxisXCoordinate() { AxisValue = sp.Argument };
                //    spa.AxisYCoordinate = new AxisYCoordinate() { AxisValue = 0 };
                //    RelativePosition pos = new RelativePosition();
                //    pos.Angle = 0;
                //    pos.ConnectorLength = 20;
                //    ann.ShapePosition = pos;
                //    ann.AnchorPoint = spa;
                //    chart.Annotations.Add(ann);
                //}



            }

        }

        public class band
        {
            // all the info should be in device unit. head is in left of band
            public System.Drawing.Point BandTopLeftLocation;
            public double BandWidth;
            public double BandHight = 50;
            public double BandHeadWidth = 40;

            public string BandName = "属性";
            public double BeginM;
            public double EndM;
            public PdfGraphics pdfGC;
            public System.Drawing.Font headFont;
            public System.Drawing.Font ContentFont;
            public Pen pPen = new Pen(Color.Black);
            // item1 measure, item2 text
            public List<Tuple<double, string>> bandData = new List<Tuple<double, string>>();

            //private Pen p = Pens.Black;
            public band()
            {
            }

            public void Draw()
            {
                DrawBandHead();
                DrawBandBorder();
                DrawBandContent();
            }
            public void DrawBandHead()
            {
                pPen.Width = 1;
                pdfGC.DrawLine(pPen, (float)BandTopLeftLocation.X, (float)BandTopLeftLocation.Y, (float)BandTopLeftLocation.X, (float)(BandTopLeftLocation.Y + BandHight));

                pdfGC.DrawLine(pPen, (float)BandTopLeftLocation.X, (float)(BandTopLeftLocation.Y + BandHight), (float)(BandTopLeftLocation.X - BandHeadWidth), (float)(BandTopLeftLocation.Y + BandHight));
                pdfGC.DrawLine(pPen, (float)(BandTopLeftLocation.X - BandHeadWidth), (float)(BandTopLeftLocation.Y + BandHight), (float)(BandTopLeftLocation.X - BandHeadWidth), (float)BandTopLeftLocation.Y);

                pdfGC.DrawLine(pPen, (float)(BandTopLeftLocation.X - BandHeadWidth), (float)BandTopLeftLocation.Y, (float)BandTopLeftLocation.X, (float)BandTopLeftLocation.Y);

                //  RectangleF rF = new RectangleF((float)(BandTopLeftLocation.X - BandHeadWidth), (float)(BandTopLeftLocation.Y), (float)BandHeadWidth, (float)BandHight);
                RectangleF rF = new RectangleF(0, 0, (float)BandHight, (float)BandHeadWidth);

                PdfStringFormat psf = new PdfStringFormat(PdfStringFormat.GenericDefault);
                psf.Alignment = PdfStringAlignment.Center;
                psf.LineAlignment = PdfStringAlignment.Center;
                // pdfGC.DrawString(BandName, textfont, Brushes.Black, rF, psf);

                pdfGC.SaveGraphicsState();
                // head box 的左下角
                pdfGC.TranslateTransform((float)(BandTopLeftLocation.X - BandHeadWidth), (float)(BandTopLeftLocation.Y + BandHight));
                pdfGC.RotateTransform(270);
                pdfGC.DrawString(BandName, headFont, new SolidBrush(Color.Black), rF, psf);
                pdfGC.RestoreGraphicsState();
            }
            public void DrawBandBorder()
            {
                Pen pPen = new Pen(Color.Black);
                pPen.Width = 1;
                pdfGC.DrawLine(pPen, (float)BandTopLeftLocation.X, (float)BandTopLeftLocation.Y, (float)(BandTopLeftLocation.X + BandWidth), (float)(BandTopLeftLocation.Y));

                pdfGC.DrawLine(pPen, (float)(BandTopLeftLocation.X + BandWidth), (float)(BandTopLeftLocation.Y), (float)(BandTopLeftLocation.X + BandWidth), (float)(BandTopLeftLocation.Y + BandHight));
                pdfGC.DrawLine(pPen, (float)(BandTopLeftLocation.X + BandWidth), (float)(BandTopLeftLocation.Y + BandHight), (float)(BandTopLeftLocation.X), (float)(BandTopLeftLocation.Y + BandHight));

                pdfGC.DrawLine(pPen, (float)(BandTopLeftLocation.X), (float)(BandTopLeftLocation.Y + BandHight), (float)BandTopLeftLocation.X, (float)BandTopLeftLocation.Y);


            }
            public void DrawBandContent()
            {
                double beginXInDC = BandTopLeftLocation.X;
                double endXInDC = BandTopLeftLocation.X + BandWidth;
                double bottomYInDC = BandTopLeftLocation.Y + BandHight;
                int indicatorLinelength = 4;

                int contentTextBoxWidth = 20;
                for (int i = 0; i < bandData.Count; i++)
                {
                    double m = bandData[i].Item1;
                    if (m < BeginM || m > EndM)
                    {
                        continue;
                    }
                    string Txt = bandData[i].Item2;

                    Double XInDC = (m - BeginM) * (endXInDC - beginXInDC) / (EndM - BeginM) + beginXInDC;
                    //指示线
                    pdfGC.DrawLine(pPen, (float)XInDC, (float)bottomYInDC, (float)XInDC, (float)bottomYInDC - indicatorLinelength);

                    RectangleF rF = new RectangleF(0, 0, (float)BandHight - indicatorLinelength, (float)contentTextBoxWidth);

                    PdfStringFormat psf = new PdfStringFormat(PdfStringFormat.GenericDefault);
                    psf.Alignment = PdfStringAlignment.Near;
                    psf.LineAlignment = PdfStringAlignment.Center;

                    pdfGC.SaveGraphicsState();
                    // head box 的左下角
                    pdfGC.TranslateTransform((float)(XInDC) - contentTextBoxWidth / 2, (float)bottomYInDC - indicatorLinelength);
                    //  pdfGC.TranslateTransform((float)(XInDC), (float)(BandTopLeftLocation.Y - BandHight - 2));
                    //  pdfGC.TranslateTransform((float)(XInDC), (float)(BandTopLeftLocation.Y - BandHight -2));
                    pdfGC.RotateTransform(270);
                    pdfGC.DrawString(Txt, ContentFont, new SolidBrush(Color.Black), rF, psf);
                    pdfGC.RestoreGraphicsState();
                }

            }
        }

        private void buttonXHeadFont_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            dlg.Font = labelbiaotou.Font;
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                labelbiaotou.Font = dlg.Font;
            }
        }

        private void buttonX1ContentFont_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            dlg.Font = labelNeirong.Font;
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                labelNeirong.Font = dlg.Font;
            }
        }
    }

}
