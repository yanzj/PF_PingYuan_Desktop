namespace PF_PingYuan_Desktop.Forms.UserInfo
{
	partial class EditUser
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.memo_Remark = new DevExpress.XtraEditors.MemoEdit();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.memo_Explanation = new DevExpress.XtraEditors.MemoEdit();
			this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
			this.combo_OperationAuthority = new DevExpress.XtraEditors.ComboBoxEdit();
			this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.txt_Department = new DevExpress.XtraEditors.TextEdit();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.txt_Password = new DevExpress.XtraEditors.TextEdit();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.txt_JobId = new DevExpress.XtraEditors.TextEdit();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.txt_UserName = new DevExpress.XtraEditors.TextEdit();
			this.btn_Reset = new DevExpress.XtraEditors.SimpleButton();
			this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
			this.panel1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.memo_Remark.Properties)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.memo_Explanation.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.combo_OperationAuthority.Properties)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txt_Department.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_Password.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_JobId.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_UserName.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.groupBox3);
			this.panel1.Controls.Add(this.groupBox2);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Location = new System.Drawing.Point(3, 5);
			this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(499, 326);
			this.panel1.TabIndex = 0;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.memo_Remark);
			this.groupBox3.Location = new System.Drawing.Point(5, 233);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox3.Size = new System.Drawing.Size(487, 84);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "备注";
			// 
			// memo_Remark
			// 
			this.memo_Remark.Location = new System.Drawing.Point(10, 21);
			this.memo_Remark.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.memo_Remark.Name = "memo_Remark";
			this.memo_Remark.Size = new System.Drawing.Size(454, 59);
			this.memo_Remark.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.memo_Explanation);
			this.groupBox2.Controls.Add(this.labelControl6);
			this.groupBox2.Controls.Add(this.combo_OperationAuthority);
			this.groupBox2.Controls.Add(this.labelControl5);
			this.groupBox2.Location = new System.Drawing.Point(5, 115);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox2.Size = new System.Drawing.Size(487, 114);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "操作权限";
			// 
			// memo_Explanation
			// 
			this.memo_Explanation.Enabled = false;
			this.memo_Explanation.Location = new System.Drawing.Point(78, 63);
			this.memo_Explanation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.memo_Explanation.Name = "memo_Explanation";
			this.memo_Explanation.Size = new System.Drawing.Size(386, 47);
			this.memo_Explanation.TabIndex = 4;
			// 
			// labelControl6
			// 
			this.labelControl6.Location = new System.Drawing.Point(10, 63);
			this.labelControl6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.labelControl6.Name = "labelControl6";
			this.labelControl6.Size = new System.Drawing.Size(75, 16);
			this.labelControl6.TabIndex = 3;
			this.labelControl6.Text = "权限解释：";
			// 
			// combo_OperationAuthority
			// 
			this.combo_OperationAuthority.Location = new System.Drawing.Point(77, 21);
			this.combo_OperationAuthority.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.combo_OperationAuthority.Name = "combo_OperationAuthority";
			this.combo_OperationAuthority.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.combo_OperationAuthority.Properties.DropDownRows = 3;
			this.combo_OperationAuthority.Properties.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
			this.combo_OperationAuthority.Properties.EditValueChanged += new System.EventHandler(this.combo_OperationAuthority_Properties_EditValueChanged);
			this.combo_OperationAuthority.Size = new System.Drawing.Size(105, 24);
			this.combo_OperationAuthority.TabIndex = 2;
			// 
			// labelControl5
			// 
			this.labelControl5.Location = new System.Drawing.Point(10, 24);
			this.labelControl5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.labelControl5.Name = "labelControl5";
			this.labelControl5.Size = new System.Drawing.Size(75, 16);
			this.labelControl5.TabIndex = 1;
			this.labelControl5.Text = "操作权限：";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.labelControl4);
			this.groupBox1.Controls.Add(this.txt_Department);
			this.groupBox1.Controls.Add(this.labelControl3);
			this.groupBox1.Controls.Add(this.txt_Password);
			this.groupBox1.Controls.Add(this.labelControl2);
			this.groupBox1.Controls.Add(this.txt_JobId);
			this.groupBox1.Controls.Add(this.labelControl1);
			this.groupBox1.Controls.Add(this.txt_UserName);
			this.groupBox1.Location = new System.Drawing.Point(2, 2);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox1.Size = new System.Drawing.Size(495, 108);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "基本信息";
			// 
			// labelControl4
			// 
			this.labelControl4.Location = new System.Drawing.Point(219, 67);
			this.labelControl4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(75, 16);
			this.labelControl4.TabIndex = 7;
			this.labelControl4.Text = "所属部门：";
			// 
			// txt_Department
			// 
			this.txt_Department.Location = new System.Drawing.Point(286, 64);
			this.txt_Department.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txt_Department.Name = "txt_Department";
			this.txt_Department.Size = new System.Drawing.Size(105, 24);
			this.txt_Department.TabIndex = 6;
			// 
			// labelControl3
			// 
			this.labelControl3.Location = new System.Drawing.Point(13, 67);
			this.labelControl3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(75, 16);
			this.labelControl3.TabIndex = 5;
			this.labelControl3.Text = "登录密码：";
			// 
			// txt_Password
			// 
			this.txt_Password.Location = new System.Drawing.Point(80, 64);
			this.txt_Password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txt_Password.Name = "txt_Password";
			this.txt_Password.Properties.UseSystemPasswordChar = true;
			this.txt_Password.Size = new System.Drawing.Size(105, 24);
			this.txt_Password.TabIndex = 4;
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(244, 27);
			this.labelControl2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(45, 16);
			this.labelControl2.TabIndex = 3;
			this.labelControl2.Text = "工号：";
			// 
			// txt_JobId
			// 
			this.txt_JobId.Location = new System.Drawing.Point(286, 24);
			this.txt_JobId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txt_JobId.Name = "txt_JobId";
			this.txt_JobId.Size = new System.Drawing.Size(105, 24);
			this.txt_JobId.TabIndex = 2;
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(25, 27);
			this.labelControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(60, 16);
			this.labelControl1.TabIndex = 1;
			this.labelControl1.Text = "用户名：";
			// 
			// txt_UserName
			// 
			this.txt_UserName.Location = new System.Drawing.Point(80, 24);
			this.txt_UserName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txt_UserName.Name = "txt_UserName";
			this.txt_UserName.Size = new System.Drawing.Size(105, 24);
			this.txt_UserName.TabIndex = 0;
			// 
			// btn_Reset
			// 
			this.btn_Reset.Location = new System.Drawing.Point(318, 335);
			this.btn_Reset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btn_Reset.Name = "btn_Reset";
			this.btn_Reset.Size = new System.Drawing.Size(78, 25);
			this.btn_Reset.TabIndex = 1;
			this.btn_Reset.Text = "重置";
			this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
			// 
			// btn_Save
			// 
			this.btn_Save.Location = new System.Drawing.Point(408, 335);
			this.btn_Save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.Size = new System.Drawing.Size(78, 25);
			this.btn_Save.TabIndex = 2;
			this.btn_Save.Text = "保存";
			this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
			// 
			// EditUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(504, 365);
			this.Controls.Add(this.btn_Save);
			this.Controls.Add(this.btn_Reset);
			this.Controls.Add(this.panel1);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "EditUser";
			this.Text = "修改信息";
			this.panel1.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.memo_Remark.Properties)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.memo_Explanation.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.combo_OperationAuthority.Properties)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txt_Department.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_Password.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_JobId.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_UserName.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.TextEdit txt_UserName;
		private DevExpress.XtraEditors.LabelControl labelControl4;
		private DevExpress.XtraEditors.TextEdit txt_Department;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.TextEdit txt_Password;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.TextEdit txt_JobId;
		private System.Windows.Forms.GroupBox groupBox2;
		private DevExpress.XtraEditors.ComboBoxEdit combo_OperationAuthority;
		private DevExpress.XtraEditors.LabelControl labelControl5;
		private DevExpress.XtraEditors.MemoEdit memo_Explanation;
		private DevExpress.XtraEditors.LabelControl labelControl6;
		private System.Windows.Forms.GroupBox groupBox3;
		private DevExpress.XtraEditors.MemoEdit memo_Remark;
		private DevExpress.XtraEditors.SimpleButton btn_Reset;
		private DevExpress.XtraEditors.SimpleButton btn_Save;
	}
}