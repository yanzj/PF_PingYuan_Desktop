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
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using DevExpress.Utils;

namespace PF_PingYuan_Desktop.Forms.ProductionPlan
{
	public partial class AddProgramCodeForm : DevExpress.XtraEditors.XtraForm
	{
		private readonly ProgramCodeDao m_programCodeDao;
		private DialogResult dialogResult;      //获取插入操作完成后MessageBox按钮值
		private AddForm4 m_parent;

		public AddProgramCodeForm()
		{
			InitializeComponent();
			m_programCodeDao = new ProgramCodeDao();
		}

		public AddProgramCodeForm(AddForm4 parent)
		{
			InitializeComponent();
			m_programCodeDao = new ProgramCodeDao();
			m_parent = parent;
		}

		private void btn_Reset_Click(object sender, EventArgs e)
		{
			SetEditValues(new ProgramCode());
		}

		private void SetEditValues(ProgramCode programCode)
		{
			this.txt_ProductCode.Text = programCode.ProductCode;
			this.txt_ProductCode.Text = programCode.ProductName;
			this.txt_PrimerColor.Text = $"{programCode.PrimerColor}";
			this.txt_PaintColor.Text = $"{programCode.PaintColor}";			
			this.txt_VarnishColor.Text = $"{programCode.VarnishColor}";			
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_Submit_Click(object sender, EventArgs e)
		{

			ProgramCode programCode = new ProgramCode
			{
				ProductCode = this.txt_ProductCode.EditValue == null ? "" : this.txt_ProductCode.EditValue.ToString(),
				ProductName = this.txt_ProductName.EditValue == null ? "" : this.txt_ProductName.EditValue.ToString(),
				PrimerColor = this.txt_PrimerColor.EditValue == null ? 0 : Convert.ToInt32(this.txt_PrimerColor.EditValue),
				PaintColor = this.txt_PaintColor.EditValue == null ? 0 : Convert.ToInt32(this.txt_PaintColor.EditValue),
				VarnishColor = this.txt_VarnishColor.EditValue == null ? 0 : Convert.ToInt32(this.txt_VarnishColor.EditValue)
			};

			int result = m_programCodeDao.InsertProgramCode(programCode);

			if (result > 0)
			{
				 dialogResult =  MessageBox.Show("添加成功");
				if(dialogResult == DialogResult.OK)
				{
					m_parent.gridControl.DataSource = m_programCodeDao.GetDataSource();
					this.Close();
				}
			}
			else
			{
				dialogResult = MessageBox.Show("添加失败");
			}
		}

		/// <summary>
		/// 创建可以在gridView的每一行添加的按钮组
		/// </summary>
		/// <param name="dicButtons"></param>
		/// <returns></returns>
		private RepositoryItemButtonEdit CreateRepositoryItemButtonEdit(Dictionary<object, string> dicButtons)
		{
			RepositoryItemButtonEdit repositoryBtn = new RepositoryItemButtonEdit();
			repositoryBtn.AppearanceDisabled.Options.UseTextOptions = true;
			repositoryBtn.AppearanceDisabled.TextOptions.HAlignment = HorzAlignment.Near;
			repositoryBtn.AutoHeight = false;
			repositoryBtn.TextEditStyle = TextEditStyles.HideTextEditor;
			repositoryBtn.ButtonsStyle = BorderStyles.UltraFlat;
			repositoryBtn.Buttons.Clear();
			EditorButton btn = null;
			foreach (KeyValuePair<object, string> item in dicButtons)
			{
				btn = new EditorButton();
				btn.Kind = ButtonPredefines.Glyph;
				btn.Caption = item.Value;
				btn.Tag = item.Key;
				repositoryBtn.Buttons.Add(btn);
			}
			return repositoryBtn;
		}
	}
}