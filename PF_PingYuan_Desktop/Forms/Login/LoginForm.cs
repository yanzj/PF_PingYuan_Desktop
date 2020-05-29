using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PF_PingYuan_Desktop.Dao;
using PF_PingYuan_Desktop.Models;
using DevExpress.XtraSplashScreen;
using DevExpress.Utils;

namespace PF_PingYuan_Desktop.Forms.Login
{
	public partial class LoginForm : DevExpress.XtraEditors.XtraForm
	{
		private readonly UserDao m_userDao;
		private Point formPoint = new Point();

		public LoginForm()
		{
			InitializeComponent();
			m_userDao = new UserDao();
		}

		private void btn_Close_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_Login_Click(object sender, EventArgs e)
		{
			if (this.txt_Username.EditValue == null || this.txt_Username.EditValue.ToString() == "")
			{
				MessageBox.Show("用户名不能为空！");
				return;
			}
			if (this.txt_Password.EditValue == null || this.txt_Password.EditValue.ToString() == "")
			{
				MessageBox.Show("密码不能为空！");
				return;
			}

			string username = this.txt_Username.EditValue.ToString();
			string pwd = this.txt_Password.EditValue.ToString();

			User user = m_userDao.FindUser(username, pwd);

			if (user != null)
			{
				this.Visible = false;

				//WaitDialogForm waitDialogForm = new WaitDialogForm("提示","正在登录");
				//waitDialogForm.SetCaption("请等待.……");
				//splashScreenManager1.ShowWaitForm();
				//SplashScreenManager.ShowForm((Form)null, typeof(WaitForm1), true, true);
				//MessageBox.Show("123");
				MainForm mainForm = new MainForm(user);

				mainForm.ShowDialog();
				//waitDialogForm.Close();
				//SplashScreenManager.CloseForm();
				//splashScreenManager1.CloseWaitForm();
				//splashScreenManager1.WaitForSplashFormClose();
				//this.DialogResult = DialogResult.OK;
				this.Dispose();
				this.Close();
				
			}
			else
			{
				MessageBox.Show("用户名或密码错误！", "Prompt message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void LoginForm_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Point myPosittion = MousePosition;
				myPosittion.Offset(-formPoint.X, -formPoint.Y);
				Location = myPosittion;
			}
		}

		private void LoginForm_MouseDown(object sender, MouseEventArgs e)
		{
			formPoint.X = e.X;
			formPoint.Y = e.Y;
		}
	}
}