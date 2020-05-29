namespace PF_PingYuan_Desktop.Forms.HistoricalProduction
{
	partial class HistoricalProductionControl
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
		///
		private void InitializeComponent()
		{
			DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
			DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions2 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
			DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions3 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
			this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
			this.dateEdit_End = new DevExpress.XtraEditors.DateEdit();
			this.dateEdit_Start = new DevExpress.XtraEditors.DateEdit();
			this.gridControl = new DevExpress.XtraGrid.GridControl();
			this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.BatchNo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.WorkpieceNo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.WorkpieceType = new DevExpress.XtraGrid.Columns.GridColumn();
			this.PrimerColor = new DevExpress.XtraGrid.Columns.GridColumn();
			this.PrimerFirm = new DevExpress.XtraGrid.Columns.GridColumn();
			this.PrimerCraft = new DevExpress.XtraGrid.Columns.GridColumn();
			this.PigmentedCoatingColor = new DevExpress.XtraGrid.Columns.GridColumn();
			this.PigmentedCoatingFirm = new DevExpress.XtraGrid.Columns.GridColumn();
			this.PigmentedCoatingCraft = new DevExpress.XtraGrid.Columns.GridColumn();
			this.VarnishColor = new DevExpress.XtraGrid.Columns.GridColumn();
			this.VarnishFirm = new DevExpress.XtraGrid.Columns.GridColumn();
			this.VarnishCraft = new DevExpress.XtraGrid.Columns.GridColumn();
			this.UpTime = new DevExpress.XtraGrid.Columns.GridColumn();
			this.RecordTimestamp = new DevExpress.XtraGrid.Columns.GridColumn();
			this.layoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
			this.itemGrid = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.windowsUIButtonPanel = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
			this.dateTimeChartRangeControlClient1 = new DevExpress.XtraEditors.DateTimeChartRangeControlClient();
			this.dateTimeChartRangeControlClient2 = new DevExpress.XtraEditors.DateTimeChartRangeControlClient();
			this.TotalNum = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
			this.layoutControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dateEdit_End.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dateEdit_End.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dateEdit_Start.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dateEdit_Start.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.itemGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dateTimeChartRangeControlClient1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dateTimeChartRangeControlClient2)).BeginInit();
			this.SuspendLayout();
			// 
			// layoutControl
			// 
			this.layoutControl.AllowCustomization = false;
			this.layoutControl.Controls.Add(this.dateEdit_End);
			this.layoutControl.Controls.Add(this.dateEdit_Start);
			this.layoutControl.Controls.Add(this.gridControl);
			this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl.Location = new System.Drawing.Point(0, 65);
			this.layoutControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.layoutControl.Name = "layoutControl";
			this.layoutControl.Root = this.layoutControlGroup;
			this.layoutControl.Size = new System.Drawing.Size(933, 581);
			this.layoutControl.TabIndex = 1;
			// 
			// dateEdit_End
			// 
			this.dateEdit_End.EditValue = null;
			this.dateEdit_End.Location = new System.Drawing.Point(531, 2);
			this.dateEdit_End.Margin = new System.Windows.Forms.Padding(2);
			this.dateEdit_End.Name = "dateEdit_End";
			this.dateEdit_End.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dateEdit_End.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dateEdit_End.Properties.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
			this.dateEdit_End.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.dateEdit_End.Properties.EditFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
			this.dateEdit_End.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.dateEdit_End.Properties.Mask.EditMask = "yyyy-MM-dd HH:mm:ss";
			this.dateEdit_End.Size = new System.Drawing.Size(353, 20);
			this.dateEdit_End.StyleController = this.layoutControl;
			this.dateEdit_End.TabIndex = 5;
			// 
			// dateEdit_Start
			// 
			this.dateEdit_Start.EditValue = null;
			this.dateEdit_Start.Location = new System.Drawing.Point(112, 2);
			this.dateEdit_Start.Margin = new System.Windows.Forms.Padding(2);
			this.dateEdit_Start.Name = "dateEdit_Start";
			this.dateEdit_Start.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dateEdit_Start.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dateEdit_Start.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
			this.dateEdit_Start.Properties.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
			this.dateEdit_Start.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.dateEdit_Start.Properties.EditFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
			this.dateEdit_Start.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.dateEdit_Start.Properties.Mask.EditMask = "yyyy-MM-dd HH:mm:ss";
			this.dateEdit_Start.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
			this.dateEdit_Start.Size = new System.Drawing.Size(352, 20);
			this.dateEdit_Start.StyleController = this.layoutControl;
			this.dateEdit_Start.TabIndex = 4;
			// 
			// gridControl
			// 
			this.gridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
			this.gridControl.Location = new System.Drawing.Point(47, 24);
			this.gridControl.MainView = this.gridView;
			this.gridControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.gridControl.Name = "gridControl";
			this.gridControl.Size = new System.Drawing.Size(839, 557);
			this.gridControl.TabIndex = 2;
			this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
			// 
			// gridView
			// 
			this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.BatchNo,
            this.WorkpieceNo,
            this.WorkpieceType,
            this.PrimerColor,
            this.PrimerFirm,
            this.PrimerCraft,
            this.PigmentedCoatingColor,
            this.PigmentedCoatingFirm,
            this.PigmentedCoatingCraft,
            this.VarnishColor,
            this.VarnishFirm,
            this.VarnishCraft,
            this.TotalNum,
            this.UpTime,
            this.RecordTimestamp});
			this.gridView.DetailHeight = 377;
			this.gridView.GridControl = this.gridControl;
			this.gridView.Name = "gridView";
			this.gridView.OptionsBehavior.Editable = false;
			this.gridView.OptionsCustomization.AllowColumnMoving = false;
			this.gridView.OptionsCustomization.AllowGroup = false;
			this.gridView.OptionsCustomization.AllowQuickHideColumns = false;
			this.gridView.OptionsMenu.EnableColumnMenu = false;
			this.gridView.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
			this.gridView.OptionsView.ShowGroupPanel = false;
			this.gridView.OptionsView.ShowIndicator = false;
			// 
			// BatchNo
			// 
			this.BatchNo.Caption = "批次编号";
			this.BatchNo.FieldName = "BatchNo";
			this.BatchNo.MinWidth = 27;
			this.BatchNo.Name = "BatchNo";
			this.BatchNo.Visible = true;
			this.BatchNo.VisibleIndex = 0;
			this.BatchNo.Width = 70;
			// 
			// WorkpieceNo
			// 
			this.WorkpieceNo.Caption = "工件编号";
			this.WorkpieceNo.FieldName = "WorkpieceNo";
			this.WorkpieceNo.MinWidth = 27;
			this.WorkpieceNo.Name = "WorkpieceNo";
			this.WorkpieceNo.Width = 70;
			// 
			// WorkpieceType
			// 
			this.WorkpieceType.Caption = "程序号";
			this.WorkpieceType.FieldName = "WorkpieceType";
			this.WorkpieceType.MinWidth = 27;
			this.WorkpieceType.Name = "WorkpieceType";
			this.WorkpieceType.Visible = true;
			this.WorkpieceType.VisibleIndex = 1;
			this.WorkpieceType.Width = 70;
			// 
			// PrimerColor
			// 
			this.PrimerColor.Caption = "底漆颜色";
			this.PrimerColor.FieldName = "PrimerColor";
			this.PrimerColor.MinWidth = 27;
			this.PrimerColor.Name = "PrimerColor";
			this.PrimerColor.Visible = true;
			this.PrimerColor.VisibleIndex = 2;
			this.PrimerColor.Width = 70;
			// 
			// PrimerFirm
			// 
			this.PrimerFirm.Caption = "底漆厂商";
			this.PrimerFirm.FieldName = "PrimerFirm";
			this.PrimerFirm.MinWidth = 27;
			this.PrimerFirm.Name = "PrimerFirm";
			this.PrimerFirm.Width = 70;
			// 
			// PrimerCraft
			// 
			this.PrimerCraft.Caption = "底漆工艺";
			this.PrimerCraft.FieldName = "PrimerCraft";
			this.PrimerCraft.MinWidth = 27;
			this.PrimerCraft.Name = "PrimerCraft";
			this.PrimerCraft.Width = 70;
			// 
			// PigmentedCoatingColor
			// 
			this.PigmentedCoatingColor.Caption = "色漆颜色";
			this.PigmentedCoatingColor.FieldName = "PigmentedCoatingColor";
			this.PigmentedCoatingColor.MinWidth = 27;
			this.PigmentedCoatingColor.Name = "PigmentedCoatingColor";
			this.PigmentedCoatingColor.Visible = true;
			this.PigmentedCoatingColor.VisibleIndex = 3;
			this.PigmentedCoatingColor.Width = 70;
			// 
			// PigmentedCoatingFirm
			// 
			this.PigmentedCoatingFirm.Caption = "色漆厂商";
			this.PigmentedCoatingFirm.FieldName = "PigmentedCoatingFirm";
			this.PigmentedCoatingFirm.MinWidth = 27;
			this.PigmentedCoatingFirm.Name = "PigmentedCoatingFirm";
			this.PigmentedCoatingFirm.Width = 70;
			// 
			// PigmentedCoatingCraft
			// 
			this.PigmentedCoatingCraft.Caption = "色漆工艺";
			this.PigmentedCoatingCraft.FieldName = "PigmentedCoatingCraft";
			this.PigmentedCoatingCraft.MinWidth = 27;
			this.PigmentedCoatingCraft.Name = "PigmentedCoatingCraft";
			this.PigmentedCoatingCraft.Width = 70;
			// 
			// VarnishColor
			// 
			this.VarnishColor.Caption = "清漆颜色";
			this.VarnishColor.FieldName = "VarnishColor";
			this.VarnishColor.MinWidth = 27;
			this.VarnishColor.Name = "VarnishColor";
			this.VarnishColor.Visible = true;
			this.VarnishColor.VisibleIndex = 4;
			this.VarnishColor.Width = 70;
			// 
			// VarnishFirm
			// 
			this.VarnishFirm.Caption = "清漆厂商";
			this.VarnishFirm.FieldName = "VarnishFirm";
			this.VarnishFirm.MinWidth = 27;
			this.VarnishFirm.Name = "VarnishFirm";
			this.VarnishFirm.Width = 70;
			// 
			// VarnishCraft
			// 
			this.VarnishCraft.Caption = "清漆工艺";
			this.VarnishCraft.FieldName = "VarnishCraft";
			this.VarnishCraft.MinWidth = 27;
			this.VarnishCraft.Name = "VarnishCraft";
			this.VarnishCraft.Width = 70;
			// 
			// UpTime
			// 
			this.UpTime.Caption = "上件时间";
			this.UpTime.FieldName = "UpTime";
			this.UpTime.MinWidth = 27;
			this.UpTime.Name = "UpTime";
			this.UpTime.Visible = true;
			this.UpTime.VisibleIndex = 6;
			this.UpTime.Width = 70;
			// 
			// RecordTimestamp
			// 
			this.RecordTimestamp.Caption = "时间戳";
			this.RecordTimestamp.FieldName = "RecordTimestamp";
			this.RecordTimestamp.MinWidth = 27;
			this.RecordTimestamp.Name = "RecordTimestamp";
			this.RecordTimestamp.Width = 70;
			// 
			// layoutControlGroup
			// 
			this.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup.GroupBordersVisible = false;
			this.layoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.itemGrid,
            this.layoutControlItem1,
            this.layoutControlItem2});
			this.layoutControlGroup.Name = "layoutControlGroup";
			this.layoutControlGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(47, 47, 0, 0);
			this.layoutControlGroup.Size = new System.Drawing.Size(933, 581);
			this.layoutControlGroup.TextVisible = false;
			// 
			// itemGrid
			// 
			this.itemGrid.Control = this.gridControl;
			this.itemGrid.Location = new System.Drawing.Point(0, 24);
			this.itemGrid.Name = "itemGrid";
			this.itemGrid.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
			this.itemGrid.Size = new System.Drawing.Size(839, 557);
			this.itemGrid.TextSize = new System.Drawing.Size(0, 0);
			this.itemGrid.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.dateEdit_Start;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(419, 24);
			this.layoutControlItem1.Text = "起始时间：";
			this.layoutControlItem1.TextSize = new System.Drawing.Size(60, 14);
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.dateEdit_End;
			this.layoutControlItem2.Location = new System.Drawing.Point(419, 0);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(420, 24);
			this.layoutControlItem2.Text = "截止时间：";
			this.layoutControlItem2.TextSize = new System.Drawing.Size(60, 14);
			// 
			// windowsUIButtonPanel
			// 
			this.windowsUIButtonPanel.AppearanceButton.Hovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
			this.windowsUIButtonPanel.AppearanceButton.Hovered.FontSizeDelta = -1;
			this.windowsUIButtonPanel.AppearanceButton.Hovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
			this.windowsUIButtonPanel.AppearanceButton.Hovered.Options.UseBackColor = true;
			this.windowsUIButtonPanel.AppearanceButton.Hovered.Options.UseFont = true;
			this.windowsUIButtonPanel.AppearanceButton.Hovered.Options.UseForeColor = true;
			this.windowsUIButtonPanel.AppearanceButton.Normal.FontSizeDelta = -1;
			this.windowsUIButtonPanel.AppearanceButton.Normal.Options.UseFont = true;
			this.windowsUIButtonPanel.AppearanceButton.Pressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
			this.windowsUIButtonPanel.AppearanceButton.Pressed.FontSizeDelta = -1;
			this.windowsUIButtonPanel.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
			this.windowsUIButtonPanel.AppearanceButton.Pressed.Options.UseBackColor = true;
			this.windowsUIButtonPanel.AppearanceButton.Pressed.Options.UseFont = true;
			this.windowsUIButtonPanel.AppearanceButton.Pressed.Options.UseForeColor = true;
			this.windowsUIButtonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
			windowsUIButtonImageOptions1.ImageUri.Uri = "Find;Size32x32;GrayScaled";
			windowsUIButtonImageOptions2.ImageUri.Uri = "ExportToXLSX;Size32x32;GrayScaled";
			windowsUIButtonImageOptions3.ImageUri.Uri = "Reset;Size32x32;GrayScaled";
			this.windowsUIButtonPanel.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("查询", true, windowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("导出", true, windowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("清空", true, windowsUIButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false)});
			this.windowsUIButtonPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.windowsUIButtonPanel.EnableImageTransparency = true;
			this.windowsUIButtonPanel.ForeColor = System.Drawing.Color.White;
			this.windowsUIButtonPanel.Location = new System.Drawing.Point(0, 0);
			this.windowsUIButtonPanel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.windowsUIButtonPanel.MaximumSize = new System.Drawing.Size(0, 65);
			this.windowsUIButtonPanel.MinimumSize = new System.Drawing.Size(70, 65);
			this.windowsUIButtonPanel.Name = "windowsUIButtonPanel";
			this.windowsUIButtonPanel.Size = new System.Drawing.Size(933, 65);
			this.windowsUIButtonPanel.TabIndex = 5;
			this.windowsUIButtonPanel.Text = "windowsUIButtonPanel";
			this.windowsUIButtonPanel.UseButtonBackgroundImages = false;
			this.windowsUIButtonPanel.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.windowsUIButtonPanel_ButtonClick);
			// 
			// TotalNum
			// 
			this.TotalNum.Caption = "上件数量";
			this.TotalNum.FieldName = "TotalNum";
			this.TotalNum.Name = "TotalNum";
			this.TotalNum.Visible = true;
			this.TotalNum.VisibleIndex = 5;
			// 
			// HistoricalProductionControl
			// 
			this.Appearance.BackColor = System.Drawing.Color.White;
			this.Appearance.Options.UseBackColor = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.layoutControl);
			this.Controls.Add(this.windowsUIButtonPanel);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "HistoricalProductionControl";
			this.Size = new System.Drawing.Size(933, 646);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
			this.layoutControl.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dateEdit_End.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dateEdit_End.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dateEdit_Start.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dateEdit_Start.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.itemGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dateTimeChartRangeControlClient1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dateTimeChartRangeControlClient2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl layoutControl;
		private DevExpress.XtraGrid.GridControl gridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup;
		private DevExpress.XtraLayout.LayoutControlItem itemGrid;
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel;
		private DevExpress.XtraEditors.DateEdit dateEdit_End;
		private DevExpress.XtraEditors.DateEdit dateEdit_Start;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraEditors.DateTimeChartRangeControlClient dateTimeChartRangeControlClient1;
		private DevExpress.XtraEditors.DateTimeChartRangeControlClient dateTimeChartRangeControlClient2;
		private DevExpress.XtraGrid.Columns.GridColumn BatchNo;
		private DevExpress.XtraGrid.Columns.GridColumn WorkpieceNo;
		private DevExpress.XtraGrid.Columns.GridColumn WorkpieceType;
		private DevExpress.XtraGrid.Columns.GridColumn PrimerColor;
		private DevExpress.XtraGrid.Columns.GridColumn PrimerFirm;
		private DevExpress.XtraGrid.Columns.GridColumn PrimerCraft;
		private DevExpress.XtraGrid.Columns.GridColumn PigmentedCoatingColor;
		private DevExpress.XtraGrid.Columns.GridColumn PigmentedCoatingFirm;
		private DevExpress.XtraGrid.Columns.GridColumn PigmentedCoatingCraft;
		private DevExpress.XtraGrid.Columns.GridColumn VarnishColor;
		private DevExpress.XtraGrid.Columns.GridColumn VarnishFirm;
		private DevExpress.XtraGrid.Columns.GridColumn VarnishCraft;
		private DevExpress.XtraGrid.Columns.GridColumn UpTime;
		private DevExpress.XtraGrid.Columns.GridColumn RecordTimestamp;
		private DevExpress.XtraGrid.Columns.GridColumn TotalNum;
	}
}
