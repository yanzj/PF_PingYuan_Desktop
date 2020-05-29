namespace PF_PingYuan_Desktop.Forms.StationInfo
{
	partial class StationInfoControl3
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
			DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions2 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
			this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.txtBox_VarnishColor = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtBox_PigmentedCoatingColor = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtBox_PrimerColor = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtBox_LoadCount = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.gridControl = new DevExpress.XtraGrid.GridControl();
			this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.layoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.windowsUIButtonPanel = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
			this.txtBox_BatchNo = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
			this.layoutControl.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			this.SuspendLayout();
			// 
			// layoutControl
			// 
			this.layoutControl.AllowCustomization = false;
			this.layoutControl.Controls.Add(this.tableLayoutPanel1);
			this.layoutControl.Controls.Add(this.gridControl);
			this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl.Location = new System.Drawing.Point(0, 102);
			this.layoutControl.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.layoutControl.Name = "layoutControl";
			this.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(928, 156, 880, 542);
			this.layoutControl.Root = this.layoutControlGroup;
			this.layoutControl.Size = new System.Drawing.Size(1333, 913);
			this.layoutControl.TabIndex = 1;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(70, 443);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1193, 467);
			this.tableLayoutPanel1.TabIndex = 5;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.groupBox3);
			this.groupBox1.Controls.Add(this.txtBox_LoadCount);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtBox_BatchNo);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(4, 4);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Size = new System.Drawing.Size(1185, 459);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "当前需要上件的工艺信息";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.txtBox_VarnishColor);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.txtBox_PigmentedCoatingColor);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.txtBox_PrimerColor);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupBox3.Location = new System.Drawing.Point(4, 97);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox3.Size = new System.Drawing.Size(1177, 358);
			this.groupBox3.TabIndex = 12;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "工艺参数";
			// 
			// txtBox_VarnishColor
			// 
			this.txtBox_VarnishColor.Location = new System.Drawing.Point(230, 216);
			this.txtBox_VarnishColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtBox_VarnishColor.Name = "txtBox_VarnishColor";
			this.txtBox_VarnishColor.Size = new System.Drawing.Size(141, 29);
			this.txtBox_VarnishColor.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(124, 220);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 22);
			this.label5.TabIndex = 6;
			this.label5.Text = "清漆颜色：";
			// 
			// txtBox_PigmentedCoatingColor
			// 
			this.txtBox_PigmentedCoatingColor.Location = new System.Drawing.Point(230, 151);
			this.txtBox_PigmentedCoatingColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtBox_PigmentedCoatingColor.Name = "txtBox_PigmentedCoatingColor";
			this.txtBox_PigmentedCoatingColor.Size = new System.Drawing.Size(141, 29);
			this.txtBox_PigmentedCoatingColor.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(124, 155);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 22);
			this.label4.TabIndex = 4;
			this.label4.Text = "色漆颜色：";
			// 
			// txtBox_PrimerColor
			// 
			this.txtBox_PrimerColor.Location = new System.Drawing.Point(230, 85);
			this.txtBox_PrimerColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtBox_PrimerColor.Name = "txtBox_PrimerColor";
			this.txtBox_PrimerColor.Size = new System.Drawing.Size(141, 29);
			this.txtBox_PrimerColor.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(124, 89);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 22);
			this.label3.TabIndex = 2;
			this.label3.Text = "底漆颜色：";
			// 
			// txtBox_LoadCount
			// 
			this.txtBox_LoadCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.txtBox_LoadCount.Location = new System.Drawing.Point(414, 41);
			this.txtBox_LoadCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtBox_LoadCount.Name = "txtBox_LoadCount";
			this.txtBox_LoadCount.Size = new System.Drawing.Size(141, 29);
			this.txtBox_LoadCount.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(306, 45);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 22);
			this.label2.TabIndex = 2;
			this.label2.Text = "上件数量：";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(34, 47);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 22);
			this.label1.TabIndex = 0;
			this.label1.Text = "批次号：";
			// 
			// gridControl
			// 
			this.gridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.gridControl.Location = new System.Drawing.Point(70, 3);
			this.gridControl.MainView = this.gridView;
			this.gridControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.gridControl.Name = "gridControl";
			this.gridControl.Size = new System.Drawing.Size(1193, 434);
			this.gridControl.TabIndex = 4;
			this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
			// 
			// gridView
			// 
			this.gridView.DetailHeight = 481;
			this.gridView.FixedLineWidth = 3;
			this.gridView.GridControl = this.gridControl;
			this.gridView.Name = "gridView";
			// 
			// layoutControlGroup
			// 
			this.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup.GroupBordersVisible = false;
			this.layoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
			this.layoutControlGroup.Name = "Root";
			this.layoutControlGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(67, 67, 0, 0);
			this.layoutControlGroup.Size = new System.Drawing.Size(1333, 913);
			this.layoutControlGroup.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.gridControl;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(1199, 440);
			this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem1.TextVisible = false;
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.tableLayoutPanel1;
			this.layoutControlItem2.Location = new System.Drawing.Point(0, 440);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(1199, 473);
			this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem2.TextVisible = false;
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
			windowsUIButtonImageOptions2.ImageUri.Uri = "Refresh;GrayScaled";
			this.windowsUIButtonPanel.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("刷新", true, windowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false)});
			this.windowsUIButtonPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.windowsUIButtonPanel.EnableImageTransparency = true;
			this.windowsUIButtonPanel.ForeColor = System.Drawing.Color.White;
			this.windowsUIButtonPanel.Location = new System.Drawing.Point(0, 0);
			this.windowsUIButtonPanel.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
			this.windowsUIButtonPanel.MaximumSize = new System.Drawing.Size(0, 102);
			this.windowsUIButtonPanel.MinimumSize = new System.Drawing.Size(100, 102);
			this.windowsUIButtonPanel.Name = "windowsUIButtonPanel";
			this.windowsUIButtonPanel.Size = new System.Drawing.Size(1333, 102);
			this.windowsUIButtonPanel.TabIndex = 5;
			this.windowsUIButtonPanel.Text = "windowsUIButtonPanel";
			this.windowsUIButtonPanel.UseButtonBackgroundImages = false;
			this.windowsUIButtonPanel.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.windowsUIButtonPanel_ButtonClick);
			// 
			// txtBox_BatchNo
			// 
			this.txtBox_BatchNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.txtBox_BatchNo.Location = new System.Drawing.Point(121, 41);
			this.txtBox_BatchNo.Margin = new System.Windows.Forms.Padding(4);
			this.txtBox_BatchNo.Name = "txtBox_BatchNo";
			this.txtBox_BatchNo.Size = new System.Drawing.Size(141, 29);
			this.txtBox_BatchNo.TabIndex = 1;
			// 
			// StationInfoControl3
			// 
			this.Appearance.BackColor = System.Drawing.Color.White;
			this.Appearance.Options.UseBackColor = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.layoutControl);
			this.Controls.Add(this.windowsUIButtonPanel);
			this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.Name = "StationInfoControl3";
			this.Size = new System.Drawing.Size(1333, 1015);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
			this.layoutControl.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl layoutControl;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup;
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel;
		private DevExpress.XtraGrid.GridControl gridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox txtBox_VarnishColor;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtBox_PigmentedCoatingColor;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtBox_PrimerColor;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtBox_LoadCount;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private System.Windows.Forms.TextBox txtBox_BatchNo;
	}
}
