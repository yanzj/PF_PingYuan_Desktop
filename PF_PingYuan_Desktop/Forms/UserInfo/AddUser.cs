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
using PF_PingYuan_Desktop.Models;
using PF_PingYuan_Desktop.Dao;

namespace PF_PingYuan_Desktop.Forms.UserInfo
{
	public partial class AddUser : DevExpress.XtraEditors.XtraForm
	{
		private readonly UserDao m_userDao;
		private UserInfoControl m_parent;

		public AddUser()
		{
			InitializeComponent();

			m_userDao = new UserDao();
		}

		public AddUser(UserInfoControl parent)
		{
			InitializeComponent();

			m_userDao = new UserDao();
			m_parent = parent;
		}
		/// <summary>
		/// 重置信息
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_Reset_Click(object sender, EventArgs e)
		{
			this.txt_UserName.EditValue = "";
			this.txt_JobId.EditValue = "";
			this.txt_Password.EditValue = "";
			this.txt_Department.EditValue = "";

			this.combo_OperationAuthority.EditValue = "";
			this.memo_Explanation.EditValue = "";
			this.memo_Remark.EditValue = "";
		}

		/// <summary>
		/// 保存信息
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_Save_Click(object sender, EventArgs e)
		{
			User user = new User();
			user.UserName = this.txt_UserName.EditValue.ToString();
			user.JobNo = this.txt_JobId.EditValue.ToString();
			user.Password = this.txt_Password.EditValue.ToString();
			user.Department = this.txt_Department.EditValue.ToString();
			user.OperationAuthority = this.combo_OperationAuthority.EditValue.ToString();
			user.Explanation = this.memo_Explanation.EditValue.ToString();
			user.Effectiveness = 1;
			user.RemarkInfo = this.memo_Remark.EditValue.ToString();
			user.RecordTimestamp = DateTime.Now;
			user.UID = 1;

			if (m_userDao.InsertUser(user) > 0)
			{
				if(MessageBox.Show("保存成功") == DialogResult.OK)
				{
					m_parent.gridControl.DataSource = m_userDao.GetDataSource();
					this.Close();
				}
			}
			else
			{
				MessageBox.Show("保存失败");
			}
		}

		private void combo_OperationAuthority_Properties_EditValueChanged(object sender, EventArgs e)
		{
			switch (this.combo_OperationAuthority.EditValue)
			{
				case "1":
					this.memo_Explanation.EditValue = "管理员权限";
					break;
				case "2":
					this.memo_Explanation.EditValue = "普通权限";
					break;
				case "3":
					this.memo_Explanation.EditValue = "其他权限";
					break;
				default:
					this.memo_Explanation.EditValue = "";
					break;
			}
		}
	}
}