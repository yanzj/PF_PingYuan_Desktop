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
	public partial class AddForm4 : DevExpress.XtraEditors.XtraForm
	{
		private readonly ProductionPlanDao  m_productionPlanDao;
		private readonly ProgramCodeDao m_programCodeDao;
		private DialogResult dialogResult;      //获取插入操作完成后MessageBox按钮值
		private readonly ProductionPlanControl m_parent;

		public AddForm4()
		{
			InitializeComponent();
			m_productionPlanDao = new ProductionPlanDao();
			m_programCodeDao = new ProgramCodeDao();

			gridControl.DataSource = m_programCodeDao.GetDataSource();
		}

		public AddForm4(ProductionPlanControl parent)
		{
			InitializeComponent();
			m_parent = parent;
			m_productionPlanDao = new ProductionPlanDao();
			this.txt_BatchNo.EditValue = DateTime.Now.ToString("yyyyMMdd");
			m_programCodeDao = new ProgramCodeDao();
			gridControl.DataSource = m_programCodeDao.GetDataSource();
		}

		private void btn_Reset_Click(object sender, EventArgs e)
		{
			SetEditValues(new Models.ProductionPlan());
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_Submit_Click(object sender, EventArgs e)
		{
			if (txt_BatchNo.EditValue == null || txt_BatchNo.EditValue.ToString() == "")
			{
				MessageBox.Show("批次号不能为空！");
				return;
			}
			if (txt_WorkpieceType.EditValue == null || txt_WorkpieceType.EditValue.ToString() == "")
			{
				MessageBox.Show("程序号不能为空！");
				return;
			}
			if (txt_PrimerColor.EditValue == null || txt_PrimerColor.EditValue.ToString() == "")
			{
				MessageBox.Show("底漆颜色不能为空！");
				return;
			}
			if (txt_PigmentedCoatingColor.EditValue ==null || txt_PigmentedCoatingColor.ToString() == "")
			{
				MessageBox.Show("色漆颜色不能为空！");
				return;
			}
			if(txt_VarnishColor.EditValue == null || txt_VarnishColor.EditValue.ToString() == "")
			{
				MessageBox.Show("清漆颜色不能为空！");
				return;
			}
			if (txt_TotalNum.EditValue == null || txt_TotalNum.ToString() == "")
			{
				MessageBox.Show("批次数量不能为空！");
				return;
			}
			if (txt_WorkpieceNo.EditValue == null || txt_TotalNum.ToString() == "")
			{
				MessageBox.Show("产品名称不能为空！");
				return;
			}
			int totalNum = txt_TotalNum.EditValue == null ? 0 : Convert.ToInt32(txt_TotalNum.EditValue);
			Models.ProductionPlan production = new Models.ProductionPlan
			{
				BatchNo = txt_BatchNo.EditValue.ToString(),
				WorkpieceNo = txt_WorkpieceNo.EditValue.ToString(),
				WorkpieceType = txt_WorkpieceType.EditValue.ToString(),
				PrimerColor = txt_PrimerColor.EditValue.ToString(),
				//PrimerFirm = txt_PrimerFirm.EditValue.ToString(),
				//PrimerCraft = txt_PrimerCraft.EditValue.ToString(),
				PigmentedCoatingColor = txt_PigmentedCoatingColor.EditValue.ToString(),
				//PigmentedCoatingFirm = txt_PigmentedCoatingFirm.EditValue.ToString(),
				//PigmentedCoatingCraft = txt_PigmentedCoatingCraft.EditValue.ToString(),
				VarnishColor = txt_VarnishColor.EditValue.ToString(),
				//VarnishFirm = txt_VarnishFirm.EditValue.ToString(),
				//VarnishCraft = txt_VarnishCraft.EditValue.ToString(),
				TotalNum = totalNum,
				Validity = 1,
				UpTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
				RecordTimestamp =   DateTime.Now,
				UID = 1
			};

			int result = m_productionPlanDao.InsertProductionPlan(production);

			if (result > 0)
			{
				 dialogResult =  MessageBox.Show("添加成功");
				if(dialogResult == DialogResult.OK)
				{
					//m_parent.m_productionPlanList.Add(production);
					m_parent.productionPlans.Add(production);

					m_parent.gridControl.DataSource = m_parent.productionPlans;
					m_parent.gridControl.RefreshDataSource();

					/*
					Dictionary<object, string> dicButtons = new Dictionary<object, string>();
					dicButtons.Add("Up", "上件");
					dicButtons.Add("Stop", "暂停");
					dicButtons.Add("Finish", "结束");
					RepositoryItemButtonEdit ribe = CreateRepositoryItemButtonEdit(dicButtons);
					ribe.ButtonClick += new ButtonPressedEventHandler(m_parent.ribe_ButtonClick);   //绑定事件

					m_parent.gridView.Columns["Operating"].ColumnEdit = ribe;
					*/
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

		/// <summary>
		/// 选择已有记录自动充填编辑框
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void historyRecordGridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
		{
			ProgramCode model = this.gridView.GetRow(e.RowHandle) as ProgramCode;
			SetEditValues(model);
		}

		private void SetEditValues(ProgramCode model)
		{
			txt_PigmentedCoatingColor.EditValue = model.PaintColor;
			txt_PrimerColor.EditValue = model.PrimerColor;
			txt_VarnishColor.EditValue = model.VarnishColor;
			txt_WorkpieceType.EditValue = model.ProductCode;
			txt_WorkpieceNo.EditValue = model.ProductName;
			txt_TotalNum.EditValue = 0;
		}

		/// <summary>
		/// 设置编辑框的值
		/// </summary>
		/// <param name="model"></param>
		public void SetEditValues(Models.ProductionPlan model)
		{
			//txt_BatchNo.EditValue = model.BatchNo;
			txt_PigmentedCoatingColor.EditValue = model.PigmentedCoatingColor;
			//txt_PigmentedCoatingCraft.EditValue = model.PigmentedCoatingCraft;
			//txt_PigmentedCoatingFirm.EditValue = model.PigmentedCoatingFirm;
			txt_PrimerColor.EditValue = model.PrimerColor;
			//txt_PrimerCraft.EditValue = model.PrimerCraft;
			//txt_PrimerFirm.EditValue = model.PrimerFirm;
			txt_VarnishColor.EditValue = model.VarnishColor;
			//txt_VarnishCraft.EditValue = model.VarnishCraft;
			//txt_VarnishFirm.EditValue = model.VarnishFirm;
			txt_WorkpieceNo.EditValue = model.WorkpieceNo;
			txt_WorkpieceType.EditValue = model.WorkpieceType;
			//date_UpTime.EditValue = string.IsNullOrEmpty(model.UpTime) ?
			//	DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") : model.UpTime;
			txt_TotalNum.EditValue = model.TotalNum;
		}

		private void btn_AddProgramCode_Click(object sender, EventArgs e)
		{
			AddProgramCodeForm form = new AddProgramCodeForm(this);
			form.Show();
		}

		private void btn_Delete_Click(object sender, EventArgs e)
		{
			int selectedIndex = this.gridView.FocusedRowHandle;
			ProgramCode model = this.gridView.GetRow(selectedIndex) as ProgramCode;

			if (MessageBox.Show("确定删除该规格?", "确认", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				int result = m_programCodeDao.DeleteProgramCodeById(model);
				if (result > 0)
				{
					if (MessageBox.Show("删除成功") == DialogResult.OK)
					{
						this.gridView.DeleteRow(selectedIndex);
					}
				}
				else
				{
					MessageBox.Show("删除失败");
				}
			}
		}
	}
}