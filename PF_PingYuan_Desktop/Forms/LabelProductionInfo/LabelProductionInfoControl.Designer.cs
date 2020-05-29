namespace PF_PingYuan_Desktop.Forms.LabelProductionInfo
{
	partial class LabelProductionInfoControl
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
			this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
			this.gridControl = new DevExpress.XtraGrid.GridControl();
			this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.layoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
			this.itemGrid = new DevExpress.XtraLayout.LayoutControlItem();
			this.windowsUIButtonPanel = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
			this.dateTimeChartRangeControlClient1 = new DevExpress.XtraEditors.DateTimeChartRangeControlClient();
			this.dateTimeChartRangeControlClient2 = new DevExpress.XtraEditors.DateTimeChartRangeControlClient();
			this.AreaNo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.RackNo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.BatchNo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.WorkpieceType = new DevExpress.XtraGrid.Columns.GridColumn();
			this.PrimerColor = new DevExpress.XtraGrid.Columns.GridColumn();
			this.PigmentedCoatingColor = new DevExpress.XtraGrid.Columns.GridColumn();
			this.VarnishColor = new DevExpress.XtraGrid.Columns.GridColumn();
			this.RecordTimestamp = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
			this.layoutControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.itemGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dateTimeChartRangeControlClient1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dateTimeChartRangeControlClient2)).BeginInit();
			this.SuspendLayout();
			// 
			// layoutControl
			// 
			this.layoutControl.AllowCustomization = false;
			this.layoutControl.Controls.Add(this.gridControl);
			this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl.Location = new System.Drawing.Point(0, 65);
			this.layoutControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.layoutControl.Name = "layoutControl";
			this.layoutControl.Root = this.layoutControlGroup;
			this.layoutControl.Size = new System.Drawing.Size(933, 581);
			this.layoutControl.TabIndex = 1;
			// 
			// gridControl
			// 
			this.gridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
			this.gridControl.Location = new System.Drawing.Point(47, 0);
			this.gridControl.MainView = this.gridView;
			this.gridControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.gridControl.Name = "gridControl";
			this.gridControl.Size = new System.Drawing.Size(839, 581);
			this.gridControl.TabIndex = 2;
			this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
			// 
			// gridView
			// 
			this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.AreaNo,
            this.RackNo,
            this.BatchNo,
            this.WorkpieceType,
            this.PrimerColor,
            this.PigmentedCoatingColor,
            this.VarnishColor,
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
			// layoutControlGroup
			// 
			this.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup.GroupBordersVisible = false;
			this.layoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.itemGrid});
			this.layoutControlGroup.Name = "layoutControlGroup";
			this.layoutControlGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(47, 47, 0, 0);
			this.layoutControlGroup.Size = new System.Drawing.Size(933, 581);
			this.layoutControlGroup.TextVisible = false;
			// 
			// itemGrid
			// 
			this.itemGrid.Control = this.gridControl;
			this.itemGrid.Location = new System.Drawing.Point(0, 0);
			this.itemGrid.Name = "itemGrid";
			this.itemGrid.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
			this.itemGrid.Size = new System.Drawing.Size(839, 581);
			this.itemGrid.TextSize = new System.Drawing.Size(0, 0);
			this.itemGrid.TextVisible = false;
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
			windowsUIButtonImageOptions1.ImageUri.Uri = "Reset;Size32x32;GrayScaled";
			this.windowsUIButtonPanel.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("刷新", true, windowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false)});
			this.windowsUIButtonPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.windowsUIButtonPanel.EnableImageTransparency = true;
			this.windowsUIButtonPanel.ForeColor = System.Drawing.Color.White;
			this.windowsUIButtonPanel.Location = new System.Drawing.Point(0, 0);
			this.windowsUIButtonPanel.Margin = new System.Windows.Forms.Padding(5);
			this.windowsUIButtonPanel.MaximumSize = new System.Drawing.Size(0, 65);
			this.windowsUIButtonPanel.MinimumSize = new System.Drawing.Size(70, 65);
			this.windowsUIButtonPanel.Name = "windowsUIButtonPanel";
			this.windowsUIButtonPanel.Size = new System.Drawing.Size(933, 65);
			this.windowsUIButtonPanel.TabIndex = 5;
			this.windowsUIButtonPanel.Text = "windowsUIButtonPanel";
			this.windowsUIButtonPanel.UseButtonBackgroundImages = false;
			this.windowsUIButtonPanel.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.windowsUIButtonPanel_ButtonClick);
			// 
			// AreaNo
			// 
			this.AreaNo.Caption = "区域号";
			this.AreaNo.FieldName = "AreaNo";
			this.AreaNo.Name = "AreaNo";
			this.AreaNo.Visible = true;
			this.AreaNo.VisibleIndex = 0;
			// 
			// RackNo
			// 
			this.RackNo.Caption = "挂具号";
			this.RackNo.FieldName = "RackNo";
			this.RackNo.Name = "RackNo";
			this.RackNo.Visible = true;
			this.RackNo.VisibleIndex = 1;
			// 
			// BatchNo
			// 
			this.BatchNo.Caption = "批次号";
			this.BatchNo.FieldName = "BatchNo";
			this.BatchNo.Name = "BatchNo";
			this.BatchNo.Visible = true;
			this.BatchNo.VisibleIndex = 2;
			// 
			// WorkpieceType
			// 
			this.WorkpieceType.Caption = "工件类型";
			this.WorkpieceType.FieldName = "WorkpieceType";
			this.WorkpieceType.Name = "WorkpieceType";
			this.WorkpieceType.Visible = true;
			this.WorkpieceType.VisibleIndex = 3;
			// 
			// PrimerColor
			// 
			this.PrimerColor.Caption = "底漆颜色";
			this.PrimerColor.FieldName = "PrimerColor";
			this.PrimerColor.Name = "PrimerColor";
			this.PrimerColor.Visible = true;
			this.PrimerColor.VisibleIndex = 4;
			// 
			// PigmentedCoatingColor
			// 
			this.PigmentedCoatingColor.Caption = "色漆颜色";
			this.PigmentedCoatingColor.FieldName = "PigmentedCoatingColor";
			this.PigmentedCoatingColor.Name = "PigmentedCoatingColor";
			this.PigmentedCoatingColor.Visible = true;
			this.PigmentedCoatingColor.VisibleIndex = 5;
			// 
			// VarnishColor
			// 
			this.VarnishColor.Caption = "清漆颜色";
			this.VarnishColor.FieldName = "VarnishColor";
			this.VarnishColor.Name = "VarnishColor";
			this.VarnishColor.Visible = true;
			this.VarnishColor.VisibleIndex = 6;
			// 
			// RecordTimestamp
			// 
			this.RecordTimestamp.Caption = "时间戳";
			this.RecordTimestamp.FieldName = "RecordTimestamp";
			this.RecordTimestamp.Name = "RecordTimestamp";
			this.RecordTimestamp.Visible = true;
			this.RecordTimestamp.VisibleIndex = 7;
			// 
			// LabelProductionInfoControl
			// 
			this.Appearance.BackColor = System.Drawing.Color.White;
			this.Appearance.Options.UseBackColor = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.layoutControl);
			this.Controls.Add(this.windowsUIButtonPanel);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "LabelProductionInfoControl";
			this.Size = new System.Drawing.Size(933, 646);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
			this.layoutControl.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.itemGrid)).EndInit();
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
		private DevExpress.XtraEditors.DateTimeChartRangeControlClient dateTimeChartRangeControlClient1;
		private DevExpress.XtraEditors.DateTimeChartRangeControlClient dateTimeChartRangeControlClient2;
		private DevExpress.XtraGrid.Columns.GridColumn AreaNo;
		private DevExpress.XtraGrid.Columns.GridColumn RackNo;
		private DevExpress.XtraGrid.Columns.GridColumn BatchNo;
		private DevExpress.XtraGrid.Columns.GridColumn WorkpieceType;
		private DevExpress.XtraGrid.Columns.GridColumn PrimerColor;
		private DevExpress.XtraGrid.Columns.GridColumn PigmentedCoatingColor;
		private DevExpress.XtraGrid.Columns.GridColumn VarnishColor;
		private DevExpress.XtraGrid.Columns.GridColumn RecordTimestamp;
	}
}
