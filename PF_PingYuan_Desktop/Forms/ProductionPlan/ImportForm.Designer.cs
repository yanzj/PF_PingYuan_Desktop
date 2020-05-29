namespace PF_PingYuan_Desktop.Forms.ProductionPlan
{
	partial class ImportForm
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
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.excelGridControl = new DevExpress.XtraGrid.GridControl();
			this.excelGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
			this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
			this.btn_Import = new DevExpress.XtraEditors.SimpleButton();
			this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.excelGridControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.excelGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
			this.panelControl2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelControl1
			// 
			this.panelControl1.Controls.Add(this.excelGridControl);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelControl1.Location = new System.Drawing.Point(0, 0);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(910, 454);
			this.panelControl1.TabIndex = 0;
			// 
			// excelGridControl
			// 
			this.excelGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.excelGridControl.Location = new System.Drawing.Point(2, 2);
			this.excelGridControl.MainView = this.excelGridView;
			this.excelGridControl.Name = "excelGridControl";
			this.excelGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
			this.excelGridControl.Size = new System.Drawing.Size(906, 450);
			this.excelGridControl.TabIndex = 0;
			this.excelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.excelGridView});
			// 
			// excelGridView
			// 
			this.excelGridView.GridControl = this.excelGridControl;
			this.excelGridView.Name = "excelGridView";
			this.excelGridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
			// 
			// repositoryItemCheckEdit1
			// 
			this.repositoryItemCheckEdit1.AutoHeight = false;
			this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
			// 
			// panelControl2
			// 
			this.panelControl2.Controls.Add(this.btn_Import);
			this.panelControl2.Controls.Add(this.btn_Delete);
			this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelControl2.Location = new System.Drawing.Point(0, 460);
			this.panelControl2.Name = "panelControl2";
			this.panelControl2.Size = new System.Drawing.Size(910, 95);
			this.panelControl2.TabIndex = 1;
			// 
			// btn_Import
			// 
			this.btn_Import.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Import.Location = new System.Drawing.Point(786, 38);
			this.btn_Import.Name = "btn_Import";
			this.btn_Import.Size = new System.Drawing.Size(112, 34);
			this.btn_Import.TabIndex = 1;
			this.btn_Import.Text = "确定";
			this.btn_Import.Click += new System.EventHandler(this.btn_Import_Click);
			// 
			// btn_Delete
			// 
			this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Delete.Location = new System.Drawing.Point(668, 38);
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.Size = new System.Drawing.Size(112, 34);
			this.btn_Delete.TabIndex = 0;
			this.btn_Delete.Text = "删除";
			this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
			// 
			// ImportForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(910, 555);
			this.Controls.Add(this.panelControl2);
			this.Controls.Add(this.panelControl1);
			this.Name = "ImportForm";
			this.Text = "导入生产计划";
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.excelGridControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.excelGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
			this.panelControl2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraGrid.GridControl excelGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView excelGridView;
		private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
		private DevExpress.XtraEditors.PanelControl panelControl2;
		private DevExpress.XtraEditors.SimpleButton btn_Import;
		private DevExpress.XtraEditors.SimpleButton btn_Delete;
	}
}