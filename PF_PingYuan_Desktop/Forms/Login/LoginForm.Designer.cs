namespace PF_PingYuan_Desktop.Forms.Login
{
	partial class LoginForm
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
			this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::PF_PingYuan_Desktop.Forms.Login.WaitForm1), true, true);
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_Login = new DevExpress.XtraEditors.SimpleButton();
			this.btn_Close = new DevExpress.XtraEditors.SimpleButton();
			this.txt_Password = new DevExpress.XtraEditors.TextEdit();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.txt_Username = new DevExpress.XtraEditors.TextEdit();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txt_Password.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_Username.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// splashScreenManager1
			// 
			this.splashScreenManager1.ClosingDelay = 500;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(146)))));
			this.panel1.Controls.Add(this.btn_Login);
			this.panel1.Controls.Add(this.btn_Close);
			this.panel1.Controls.Add(this.txt_Password);
			this.panel1.Controls.Add(this.labelControl2);
			this.panel1.Controls.Add(this.txt_Username);
			this.panel1.Controls.Add(this.labelControl1);
			this.panel1.Location = new System.Drawing.Point(192, 74);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(371, 296);
			this.panel1.TabIndex = 0;
			// 
			// btn_Login
			// 
			this.btn_Login.Location = new System.Drawing.Point(207, 246);
			this.btn_Login.Name = "btn_Login";
			this.btn_Login.Size = new System.Drawing.Size(102, 34);
			this.btn_Login.TabIndex = 5;
			this.btn_Login.Text = "登录";
			this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
			// 
			// btn_Close
			// 
			this.btn_Close.Location = new System.Drawing.Point(92, 246);
			this.btn_Close.Name = "btn_Close";
			this.btn_Close.Size = new System.Drawing.Size(94, 34);
			this.btn_Close.TabIndex = 4;
			this.btn_Close.Text = "取消";
			this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
			// 
			// txt_Password
			// 
			this.txt_Password.Location = new System.Drawing.Point(64, 187);
			this.txt_Password.Name = "txt_Password";
			this.txt_Password.Properties.PasswordChar = '*';
			this.txt_Password.Size = new System.Drawing.Size(267, 30);
			this.txt_Password.TabIndex = 3;
			// 
			// labelControl2
			// 
			this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
			this.labelControl2.Appearance.Options.UseForeColor = true;
			this.labelControl2.Location = new System.Drawing.Point(216, 54);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(123, 22);
			this.labelControl2.TabIndex = 2;
			this.labelControl2.Text = "-Pepperl+Fuchs";
			// 
			// txt_Username
			// 
			this.txt_Username.Location = new System.Drawing.Point(64, 127);
			this.txt_Username.Name = "txt_Username";
			this.txt_Username.Size = new System.Drawing.Size(267, 30);
			this.txt_Username.TabIndex = 1;
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
			this.labelControl1.Appearance.Options.UseForeColor = true;
			this.labelControl1.Location = new System.Drawing.Point(72, 26);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(237, 22);
			this.labelControl1.TabIndex = 0;
			this.labelControl1.Text = "Your Automation,Our Passion.\r\n";
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
			this.BackgroundImageStore = global::PF_PingYuan_Desktop.Properties.Resources.background4;
			this.ClientSize = new System.Drawing.Size(761, 449);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LoginForm";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseMove);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txt_Password.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_Username.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.TextEdit txt_Username;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.TextEdit txt_Password;
		private DevExpress.XtraEditors.SimpleButton btn_Login;
		private DevExpress.XtraEditors.SimpleButton btn_Close;
		private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
	}
}