using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.ComponentModel.DataAnnotations;
using PF_PingYuan_Desktop.Models;
using PF_PingYuan_Desktop.Dao;

namespace PF_PingYuan_Desktop.Forms.UserInfo
{
	public partial class UserInfoControl : DevExpress.XtraEditors.XtraUserControl
	{
		private readonly UserDao _userDao;
		private AddUser m_AddUserForm;
		private EditUser m_EditUserForm;

		public List<User> Users { get; set; }

		public UserInfoControl()
		{
			InitializeComponent();

			_userDao = new UserDao();
			gridControl.DataSource = _userDao.GetDataSource();
		}
		void windowsUIButtonPanel_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
		{
			if (e.Button.Properties.Caption == "Print") gridControl.ShowRibbonPrintPreview();
			switch (e.Button.Properties.Caption) 
			{
				case "添加":
					m_AddUserForm =
					   (m_AddUserForm == null || m_AddUserForm.IsDisposed) ? new AddUser(this) : m_AddUserForm;
					m_AddUserForm.Show();
					break;
				case "修改":
					User user = 	this.gridView.GetRow(this.gridView.FocusedRowHandle) as User;
					m_EditUserForm =
					   (m_EditUserForm == null || m_EditUserForm.IsDisposed) ? new EditUser(this, user.JobNo) : m_EditUserForm;
					m_EditUserForm.Show();
					break;
				case "删除":
					this.gridView.DeleteSelectedRows();
					break;
				case "刷新":
					this.gridControl.Refresh();
					break;
			}
		}
	}
}
