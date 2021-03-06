﻿namespace LibCerMap
{
    partial class FrmSymbol
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSymbol));
            this.axSymbologyControl = new ESRI.ArcGIS.Controls.AxSymbologyControl();
            this.gPanelPreview = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.ImagePreview = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.gPanelLine = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btEditLine = new DevComponents.DotNetBar.ButtonX();
            this.labLineSize = new DevComponents.DotNetBar.LabelX();
            this.LineSize = new DevComponents.Editors.DoubleInput();
            this.colorLine = new LibCerMap.CustomColorPicker();
            this.labLineColor = new DevComponents.DotNetBar.LabelX();
            this.gPanelPolygon = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btEditPolygon = new DevComponents.DotNetBar.ButtonX();
            this.colorOutLine = new LibCerMap.CustomColorPicker();
            this.labOutLineColor = new DevComponents.DotNetBar.LabelX();
            this.PolygonSize = new DevComponents.Editors.DoubleInput();
            this.labPolygonSize = new DevComponents.DotNetBar.LabelX();
            this.colorPolygon = new LibCerMap.CustomColorPicker();
            this.labPolygonColor = new DevComponents.DotNetBar.LabelX();
            this.gPanelPoint = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btEditPoint = new DevComponents.DotNetBar.ButtonX();
            this.PointAngle = new DevComponents.Editors.DoubleInput();
            this.colorPoint = new LibCerMap.CustomColorPicker();
            this.labPointAngle = new DevComponents.DotNetBar.LabelX();
            this.labPoint = new DevComponents.DotNetBar.LabelX();
            this.PointSize = new DevComponents.Editors.DoubleInput();
            this.labPointSize = new DevComponents.DotNetBar.LabelX();
            this.labMarkerColor = new DevComponents.DotNetBar.LabelX();
            this.gPanelMarker = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.colorPickerButton1 = new LibCerMap.CustomColorPicker();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.btOK = new DevComponents.DotNetBar.ButtonX();
            this.btCancel = new DevComponents.DotNetBar.ButtonX();
            this.btAddStyle = new DevComponents.DotNetBar.ButtonX();
            this.colorPickerButton2 = new LibCerMap.CustomColorPicker();
            this.colorPolygons = new LibCerMap.CustomColorPicker();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            ((System.ComponentModel.ISupportInitialize)(this.axSymbologyControl)).BeginInit();
            this.gPanelPreview.SuspendLayout();
            this.gPanelLine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LineSize)).BeginInit();
            this.gPanelPolygon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PolygonSize)).BeginInit();
            this.gPanelPoint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PointAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointSize)).BeginInit();
            this.gPanelMarker.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.panelEx2.SuspendLayout();
            this.SuspendLayout();
            // 
            // axSymbologyControl
            // 
            this.axSymbologyControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axSymbologyControl.Location = new System.Drawing.Point(0, 0);
            this.axSymbologyControl.Name = "axSymbologyControl";
            this.axSymbologyControl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axSymbologyControl.OcxState")));
            this.axSymbologyControl.Size = new System.Drawing.Size(314, 439);
            this.axSymbologyControl.TabIndex = 0;
            this.axSymbologyControl.OnDoubleClick += new ESRI.ArcGIS.Controls.ISymbologyControlEvents_Ax_OnDoubleClickEventHandler(this.axSymbologyControl_OnDoubleClick);
            this.axSymbologyControl.OnItemSelected += new ESRI.ArcGIS.Controls.ISymbologyControlEvents_Ax_OnItemSelectedEventHandler(this.axSymbologyControl_OnItemSelected);
            // 
            // gPanelPreview
            // 
            this.gPanelPreview.CanvasColor = System.Drawing.SystemColors.Control;
            this.gPanelPreview.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.gPanelPreview.Controls.Add(this.ImagePreview);
            this.gPanelPreview.Location = new System.Drawing.Point(12, 9);
            this.gPanelPreview.Name = "gPanelPreview";
            this.gPanelPreview.Size = new System.Drawing.Size(159, 146);
            // 
            // 
            // 
            this.gPanelPreview.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gPanelPreview.Style.BackColorGradientAngle = 90;
            this.gPanelPreview.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gPanelPreview.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gPanelPreview.Style.BorderBottomWidth = 1;
            this.gPanelPreview.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gPanelPreview.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gPanelPreview.Style.BorderLeftWidth = 1;
            this.gPanelPreview.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gPanelPreview.Style.BorderRightWidth = 1;
            this.gPanelPreview.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gPanelPreview.Style.BorderTopWidth = 1;
            this.gPanelPreview.Style.CornerDiameter = 4;
            this.gPanelPreview.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gPanelPreview.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gPanelPreview.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gPanelPreview.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gPanelPreview.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gPanelPreview.TabIndex = 11;
            this.gPanelPreview.Text = "预览";
            // 
            // ImagePreview
            // 
            // 
            // 
            // 
            this.ImagePreview.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ImagePreview.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.ImagePreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImagePreview.Image = ((System.Drawing.Image)(resources.GetObject("ImagePreview.Image")));
            this.ImagePreview.Location = new System.Drawing.Point(0, 0);
            this.ImagePreview.Name = "ImagePreview";
            this.ImagePreview.Size = new System.Drawing.Size(153, 122);
            this.ImagePreview.TabIndex = 0;
            // 
            // gPanelLine
            // 
            this.gPanelLine.CanvasColor = System.Drawing.SystemColors.Control;
            this.gPanelLine.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.gPanelLine.Controls.Add(this.btEditLine);
            this.gPanelLine.Controls.Add(this.labLineSize);
            this.gPanelLine.Controls.Add(this.LineSize);
            this.gPanelLine.Controls.Add(this.colorLine);
            this.gPanelLine.Controls.Add(this.labLineColor);
            this.gPanelLine.Location = new System.Drawing.Point(10, 164);
            this.gPanelLine.Name = "gPanelLine";
            this.gPanelLine.Size = new System.Drawing.Size(159, 185);
            // 
            // 
            // 
            this.gPanelLine.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gPanelLine.Style.BackColorGradientAngle = 90;
            this.gPanelLine.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gPanelLine.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gPanelLine.Style.BorderBottomWidth = 1;
            this.gPanelLine.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gPanelLine.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gPanelLine.Style.BorderLeftWidth = 1;
            this.gPanelLine.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gPanelLine.Style.BorderRightWidth = 1;
            this.gPanelLine.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gPanelLine.Style.BorderTopWidth = 1;
            this.gPanelLine.Style.CornerDiameter = 4;
            this.gPanelLine.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gPanelLine.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gPanelLine.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gPanelLine.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gPanelLine.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gPanelLine.TabIndex = 12;
            this.gPanelLine.Text = "设计";
            // 
            // btEditLine
            // 
            this.btEditLine.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btEditLine.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btEditLine.Location = new System.Drawing.Point(29, 100);
            this.btEditLine.Name = "btEditLine";
            this.btEditLine.Size = new System.Drawing.Size(101, 23);
            this.btEditLine.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btEditLine.TabIndex = 20;
            this.btEditLine.Text = "编辑符号";
            this.btEditLine.Click += new System.EventHandler(this.btEditLine_Click);
            // 
            // labLineSize
            // 
            this.labLineSize.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labLineSize.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labLineSize.Location = new System.Drawing.Point(14, 58);
            this.labLineSize.Name = "labLineSize";
            this.labLineSize.Size = new System.Drawing.Size(44, 23);
            this.labLineSize.TabIndex = 16;
            this.labLineSize.Text = "宽度：";
            // 
            // LineSize
            // 
            // 
            // 
            // 
            this.LineSize.BackgroundStyle.Class = "DateTimeInputBackground";
            this.LineSize.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LineSize.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.LineSize.Increment = 1D;
            this.LineSize.Location = new System.Drawing.Point(60, 58);
            this.LineSize.MinValue = 0D;
            this.LineSize.Name = "LineSize";
            this.LineSize.ShowUpDown = true;
            this.LineSize.Size = new System.Drawing.Size(80, 21);
            this.LineSize.TabIndex = 19;
            this.LineSize.Value = 5D;
            this.LineSize.ValueChanged += new System.EventHandler(this.LineSize_ValueChanged);
            // 
            // colorLine
            // 
            this.colorLine.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.colorLine.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.colorLine.Image = ((System.Drawing.Image)(resources.GetObject("colorLine.Image")));
            this.colorLine.Location = new System.Drawing.Point(60, 8);
            this.colorLine.Name = "colorLine";
            this.colorLine.SelectedColorImageRectangle = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.colorLine.Size = new System.Drawing.Size(37, 23);
            this.colorLine.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.colorLine.TabIndex = 2;
            this.colorLine.SelectedColorChanged += new System.EventHandler(this.colorLine_SelectedColorChanged);
            // 
            // labLineColor
            // 
            this.labLineColor.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labLineColor.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labLineColor.Location = new System.Drawing.Point(16, 8);
            this.labLineColor.Name = "labLineColor";
            this.labLineColor.Size = new System.Drawing.Size(42, 23);
            this.labLineColor.TabIndex = 1;
            this.labLineColor.Text = "颜色：";
            // 
            // gPanelPolygon
            // 
            this.gPanelPolygon.CanvasColor = System.Drawing.SystemColors.Control;
            this.gPanelPolygon.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.gPanelPolygon.Controls.Add(this.btEditPolygon);
            this.gPanelPolygon.Controls.Add(this.colorOutLine);
            this.gPanelPolygon.Controls.Add(this.labOutLineColor);
            this.gPanelPolygon.Controls.Add(this.PolygonSize);
            this.gPanelPolygon.Controls.Add(this.labPolygonSize);
            this.gPanelPolygon.Controls.Add(this.colorPolygon);
            this.gPanelPolygon.Controls.Add(this.labPolygonColor);
            this.gPanelPolygon.Location = new System.Drawing.Point(10, 164);
            this.gPanelPolygon.Name = "gPanelPolygon";
            this.gPanelPolygon.Size = new System.Drawing.Size(159, 185);
            // 
            // 
            // 
            this.gPanelPolygon.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gPanelPolygon.Style.BackColorGradientAngle = 90;
            this.gPanelPolygon.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gPanelPolygon.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gPanelPolygon.Style.BorderBottomWidth = 1;
            this.gPanelPolygon.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gPanelPolygon.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gPanelPolygon.Style.BorderLeftWidth = 1;
            this.gPanelPolygon.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gPanelPolygon.Style.BorderRightWidth = 1;
            this.gPanelPolygon.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gPanelPolygon.Style.BorderTopWidth = 1;
            this.gPanelPolygon.Style.CornerDiameter = 4;
            this.gPanelPolygon.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gPanelPolygon.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gPanelPolygon.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gPanelPolygon.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gPanelPolygon.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gPanelPolygon.TabIndex = 13;
            this.gPanelPolygon.Text = "设计";
            // 
            // btEditPolygon
            // 
            this.btEditPolygon.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btEditPolygon.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btEditPolygon.Location = new System.Drawing.Point(26, 127);
            this.btEditPolygon.Name = "btEditPolygon";
            this.btEditPolygon.Size = new System.Drawing.Size(101, 23);
            this.btEditPolygon.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btEditPolygon.TabIndex = 22;
            this.btEditPolygon.Text = "编辑符号";
            this.btEditPolygon.Click += new System.EventHandler(this.btEditPolygon_Click);
            // 
            // colorOutLine
            // 
            this.colorOutLine.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.colorOutLine.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.colorOutLine.Image = ((System.Drawing.Image)(resources.GetObject("colorOutLine.Image")));
            this.colorOutLine.Location = new System.Drawing.Point(65, 89);
            this.colorOutLine.Name = "colorOutLine";
            this.colorOutLine.SelectedColorImageRectangle = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.colorOutLine.Size = new System.Drawing.Size(37, 23);
            this.colorOutLine.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.colorOutLine.TabIndex = 21;
            this.colorOutLine.SelectedColorChanged += new System.EventHandler(this.colorOutLine_SelectedColorChanged);
            // 
            // labOutLineColor
            // 
            this.labOutLineColor.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labOutLineColor.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labOutLineColor.Location = new System.Drawing.Point(12, 89);
            this.labOutLineColor.Name = "labOutLineColor";
            this.labOutLineColor.Size = new System.Drawing.Size(56, 23);
            this.labOutLineColor.TabIndex = 17;
            this.labOutLineColor.Text = "外线色：";
            // 
            // PolygonSize
            // 
            // 
            // 
            // 
            this.PolygonSize.BackgroundStyle.Class = "DateTimeInputBackground";
            this.PolygonSize.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.PolygonSize.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.PolygonSize.Increment = 1D;
            this.PolygonSize.Location = new System.Drawing.Point(65, 52);
            this.PolygonSize.MinValue = 0D;
            this.PolygonSize.Name = "PolygonSize";
            this.PolygonSize.ShowUpDown = true;
            this.PolygonSize.Size = new System.Drawing.Size(80, 21);
            this.PolygonSize.TabIndex = 20;
            this.PolygonSize.Value = 2D;
            this.PolygonSize.ValueChanged += new System.EventHandler(this.PolygonSize_ValueChanged);
            // 
            // labPolygonSize
            // 
            this.labPolygonSize.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labPolygonSize.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labPolygonSize.Location = new System.Drawing.Point(12, 50);
            this.labPolygonSize.Name = "labPolygonSize";
            this.labPolygonSize.Size = new System.Drawing.Size(44, 23);
            this.labPolygonSize.TabIndex = 16;
            this.labPolygonSize.Text = "宽度：";
            // 
            // colorPolygon
            // 
            this.colorPolygon.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.colorPolygon.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.colorPolygon.Image = ((System.Drawing.Image)(resources.GetObject("colorPolygon.Image")));
            this.colorPolygon.Location = new System.Drawing.Point(65, 8);
            this.colorPolygon.Name = "colorPolygon";
            this.colorPolygon.SelectedColorImageRectangle = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.colorPolygon.Size = new System.Drawing.Size(37, 23);
            this.colorPolygon.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.colorPolygon.TabIndex = 2;
            this.colorPolygon.SelectedColorChanged += new System.EventHandler(this.colorPolygon_SelectedColorChanged);
            // 
            // labPolygonColor
            // 
            this.labPolygonColor.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labPolygonColor.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labPolygonColor.Location = new System.Drawing.Point(12, 8);
            this.labPolygonColor.Name = "labPolygonColor";
            this.labPolygonColor.Size = new System.Drawing.Size(47, 23);
            this.labPolygonColor.TabIndex = 1;
            this.labPolygonColor.Text = "颜色：";
            // 
            // gPanelPoint
            // 
            this.gPanelPoint.CanvasColor = System.Drawing.SystemColors.Control;
            this.gPanelPoint.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.gPanelPoint.Controls.Add(this.btEditPoint);
            this.gPanelPoint.Controls.Add(this.PointAngle);
            this.gPanelPoint.Controls.Add(this.colorPoint);
            this.gPanelPoint.Controls.Add(this.labPointAngle);
            this.gPanelPoint.Controls.Add(this.labPoint);
            this.gPanelPoint.Controls.Add(this.PointSize);
            this.gPanelPoint.Controls.Add(this.labPointSize);
            this.gPanelPoint.Location = new System.Drawing.Point(10, 164);
            this.gPanelPoint.Name = "gPanelPoint";
            this.gPanelPoint.Size = new System.Drawing.Size(159, 185);
            // 
            // 
            // 
            this.gPanelPoint.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gPanelPoint.Style.BackColorGradientAngle = 90;
            this.gPanelPoint.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gPanelPoint.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gPanelPoint.Style.BorderBottomWidth = 1;
            this.gPanelPoint.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gPanelPoint.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gPanelPoint.Style.BorderLeftWidth = 1;
            this.gPanelPoint.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gPanelPoint.Style.BorderRightWidth = 1;
            this.gPanelPoint.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gPanelPoint.Style.BorderTopWidth = 1;
            this.gPanelPoint.Style.CornerDiameter = 4;
            this.gPanelPoint.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gPanelPoint.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gPanelPoint.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gPanelPoint.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gPanelPoint.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gPanelPoint.TabIndex = 14;
            this.gPanelPoint.Text = "设计";
            // 
            // btEditPoint
            // 
            this.btEditPoint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btEditPoint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btEditPoint.Location = new System.Drawing.Point(24, 129);
            this.btEditPoint.Name = "btEditPoint";
            this.btEditPoint.Size = new System.Drawing.Size(101, 23);
            this.btEditPoint.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btEditPoint.TabIndex = 19;
            this.btEditPoint.Text = "编辑符号";
            this.btEditPoint.Click += new System.EventHandler(this.btEditPoint_Click);
            // 
            // PointAngle
            // 
            // 
            // 
            // 
            this.PointAngle.BackgroundStyle.Class = "DateTimeInputBackground";
            this.PointAngle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.PointAngle.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.PointAngle.Increment = 1D;
            this.PointAngle.Location = new System.Drawing.Point(54, 89);
            this.PointAngle.MaxValue = 360D;
            this.PointAngle.MinValue = -360D;
            this.PointAngle.Name = "PointAngle";
            this.PointAngle.ShowUpDown = true;
            this.PointAngle.Size = new System.Drawing.Size(80, 21);
            this.PointAngle.TabIndex = 18;
            this.PointAngle.ValueChanged += new System.EventHandler(this.PointAngle_ValueChanged);
            // 
            // colorPoint
            // 
            this.colorPoint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.colorPoint.BackColor = System.Drawing.SystemColors.Control;
            this.colorPoint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.colorPoint.Image = ((System.Drawing.Image)(resources.GetObject("colorPoint.Image")));
            this.colorPoint.Location = new System.Drawing.Point(54, 8);
            this.colorPoint.Name = "colorPoint";
            this.colorPoint.SelectedColorImageRectangle = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.colorPoint.Size = new System.Drawing.Size(37, 23);
            this.colorPoint.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.colorPoint.TabIndex = 3;
            this.colorPoint.SelectedColorChanged += new System.EventHandler(this.colorPoint_SelectedColorChanged);
            // 
            // labPointAngle
            // 
            this.labPointAngle.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labPointAngle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labPointAngle.Location = new System.Drawing.Point(12, 89);
            this.labPointAngle.Name = "labPointAngle";
            this.labPointAngle.Size = new System.Drawing.Size(44, 23);
            this.labPointAngle.TabIndex = 16;
            this.labPointAngle.Text = "角度:";
            // 
            // labPoint
            // 
            this.labPoint.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labPoint.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labPoint.Location = new System.Drawing.Point(12, 8);
            this.labPoint.Name = "labPoint";
            this.labPoint.Size = new System.Drawing.Size(44, 23);
            this.labPoint.TabIndex = 2;
            this.labPoint.Text = "颜色：";
            // 
            // PointSize
            // 
            // 
            // 
            // 
            this.PointSize.BackgroundStyle.Class = "DateTimeInputBackground";
            this.PointSize.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.PointSize.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.PointSize.Increment = 1D;
            this.PointSize.Location = new System.Drawing.Point(54, 50);
            this.PointSize.MinValue = 1D;
            this.PointSize.Name = "PointSize";
            this.PointSize.ShowUpDown = true;
            this.PointSize.Size = new System.Drawing.Size(80, 21);
            this.PointSize.TabIndex = 18;
            this.PointSize.Value = 18D;
            this.PointSize.ValueChanged += new System.EventHandler(this.PointSize_ValueChanged);
            // 
            // labPointSize
            // 
            this.labPointSize.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labPointSize.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labPointSize.Location = new System.Drawing.Point(12, 50);
            this.labPointSize.Name = "labPointSize";
            this.labPointSize.Size = new System.Drawing.Size(44, 23);
            this.labPointSize.TabIndex = 15;
            this.labPointSize.Text = "大小：";
            // 
            // labMarkerColor
            // 
            this.labMarkerColor.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labMarkerColor.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labMarkerColor.Location = new System.Drawing.Point(12, 8);
            this.labMarkerColor.Name = "labMarkerColor";
            this.labMarkerColor.Size = new System.Drawing.Size(35, 23);
            this.labMarkerColor.TabIndex = 0;
            this.labMarkerColor.Text = "颜色:";
            // 
            // gPanelMarker
            // 
            this.gPanelMarker.CanvasColor = System.Drawing.SystemColors.Control;
            this.gPanelMarker.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.gPanelMarker.Controls.Add(this.colorPickerButton1);
            this.gPanelMarker.Controls.Add(this.labMarkerColor);
            this.gPanelMarker.Location = new System.Drawing.Point(256, 155);
            this.gPanelMarker.Name = "gPanelMarker";
            this.gPanelMarker.Size = new System.Drawing.Size(163, 146);
            // 
            // 
            // 
            this.gPanelMarker.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gPanelMarker.Style.BackColorGradientAngle = 90;
            this.gPanelMarker.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gPanelMarker.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gPanelMarker.Style.BorderBottomWidth = 1;
            this.gPanelMarker.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gPanelMarker.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gPanelMarker.Style.BorderLeftWidth = 1;
            this.gPanelMarker.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gPanelMarker.Style.BorderRightWidth = 1;
            this.gPanelMarker.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gPanelMarker.Style.BorderTopWidth = 1;
            this.gPanelMarker.Style.CornerDiameter = 4;
            this.gPanelMarker.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gPanelMarker.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gPanelMarker.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gPanelMarker.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gPanelMarker.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gPanelMarker.TabIndex = 14;
            this.gPanelMarker.Text = "设计";
            // 
            // colorPickerButton1
            // 
            this.colorPickerButton1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.colorPickerButton1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.colorPickerButton1.Image = ((System.Drawing.Image)(resources.GetObject("colorPickerButton1.Image")));
            this.colorPickerButton1.Location = new System.Drawing.Point(53, 8);
            this.colorPickerButton1.Name = "colorPickerButton1";
            this.colorPickerButton1.SelectedColorImageRectangle = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.colorPickerButton1.Size = new System.Drawing.Size(37, 23);
            this.colorPickerButton1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.colorPickerButton1.TabIndex = 18;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(476, 102);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 15;
            this.labelX2.Text = "labelX2";
            // 
            // btOK
            // 
            this.btOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btOK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOK.Location = new System.Drawing.Point(15, 393);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btOK.TabIndex = 15;
            this.btOK.Text = "确定";
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btCancel
            // 
            this.btCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(97, 393);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btCancel.TabIndex = 16;
            this.btCancel.Text = "取消";
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btAddStyle
            // 
            this.btAddStyle.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btAddStyle.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btAddStyle.Location = new System.Drawing.Point(19, 355);
            this.btAddStyle.Name = "btAddStyle";
            this.btAddStyle.Size = new System.Drawing.Size(141, 23);
            this.btAddStyle.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btAddStyle.TabIndex = 17;
            this.btAddStyle.Text = "加载样式";
            this.btAddStyle.Click += new System.EventHandler(this.btAddStyle_Click);
            // 
            // colorPickerButton2
            // 
            this.colorPickerButton2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.colorPickerButton2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.colorPickerButton2.Image = ((System.Drawing.Image)(resources.GetObject("colorPickerButton2.Image")));
            this.colorPickerButton2.Location = new System.Drawing.Point(57, 8);
            this.colorPickerButton2.Name = "colorPickerButton2";
            this.colorPickerButton2.SelectedColorImageRectangle = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.colorPickerButton2.Size = new System.Drawing.Size(37, 23);
            this.colorPickerButton2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.colorPickerButton2.TabIndex = 2;
            // 
            // colorPolygons
            // 
            this.colorPolygons.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.colorPolygons.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.colorPolygons.Image = ((System.Drawing.Image)(resources.GetObject("colorPolygons.Image")));
            this.colorPolygons.Location = new System.Drawing.Point(55, 8);
            this.colorPolygons.Name = "colorPolygons";
            this.colorPolygons.SelectedColorImageRectangle = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.colorPolygons.Size = new System.Drawing.Size(37, 23);
            this.colorPolygons.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.colorPolygons.TabIndex = 2;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.gPanelPreview);
            this.panelEx1.Controls.Add(this.gPanelLine);
            this.panelEx1.Controls.Add(this.gPanelPoint);
            this.panelEx1.Controls.Add(this.btAddStyle);
            this.panelEx1.Controls.Add(this.gPanelPolygon);
            this.panelEx1.Controls.Add(this.btCancel);
            this.panelEx1.Controls.Add(this.btOK);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelEx1.Location = new System.Drawing.Point(314, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(180, 439);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 18;
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.axSymbologyControl);
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx2.Location = new System.Drawing.Point(0, 0);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(314, 439);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 19;
            // 
            // FrmSymbol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 439);
            this.Controls.Add(this.panelEx2);
            this.Controls.Add(this.panelEx1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSymbol";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选择样式";
            this.Load += new System.EventHandler(this.FrmSymbol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axSymbologyControl)).EndInit();
            this.gPanelPreview.ResumeLayout(false);
            this.gPanelLine.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LineSize)).EndInit();
            this.gPanelPolygon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PolygonSize)).EndInit();
            this.gPanelPoint.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PointAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointSize)).EndInit();
            this.gPanelMarker.ResumeLayout(false);
            this.panelEx1.ResumeLayout(false);
            this.panelEx2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ESRI.ArcGIS.Controls.AxSymbologyControl axSymbologyControl;
        private DevComponents.DotNetBar.Controls.GroupPanel gPanelPreview;
        private DevComponents.DotNetBar.Controls.ReflectionImage ImagePreview;
        private DevComponents.DotNetBar.Controls.GroupPanel gPanelLine;
        private DevComponents.DotNetBar.Controls.GroupPanel gPanelPolygon;
        private DevComponents.DotNetBar.Controls.GroupPanel gPanelPoint;
        private DevComponents.DotNetBar.LabelX labLineColor;
        private DevComponents.DotNetBar.LabelX labPolygonColor;
        private DevComponents.DotNetBar.LabelX labMarkerColor;
        private DevComponents.DotNetBar.LabelX labPointSize;
        private DevComponents.DotNetBar.LabelX labPointAngle;
        private DevComponents.DotNetBar.LabelX labOutLineColor;
        private CustomColorPicker colorLine;
        private CustomColorPicker colorPolygon;
        private CustomColorPicker colorPickerButton1;
        private DevComponents.DotNetBar.Controls.GroupPanel gPanelMarker;
        private CustomColorPicker colorPoint;
        private DevComponents.DotNetBar.LabelX labPoint;
        private CustomColorPicker colorPickerButton2;
        private CustomColorPicker colorPolygons;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labLineSize;
        private DevComponents.Editors.DoubleInput LineSize;
        private DevComponents.Editors.DoubleInput PolygonSize;
        private DevComponents.DotNetBar.LabelX labPolygonSize;
        private DevComponents.Editors.DoubleInput PointSize;
        private DevComponents.Editors.DoubleInput PointAngle;
        private CustomColorPicker colorOutLine;
        private DevComponents.DotNetBar.ButtonX btOK;
        private DevComponents.DotNetBar.ButtonX btCancel;
        private DevComponents.DotNetBar.ButtonX btAddStyle;
        private DevComponents.DotNetBar.ButtonX btEditPoint;
        private DevComponents.DotNetBar.ButtonX btEditLine;
        private DevComponents.DotNetBar.ButtonX btEditPolygon;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.PanelEx panelEx2;
    }
}