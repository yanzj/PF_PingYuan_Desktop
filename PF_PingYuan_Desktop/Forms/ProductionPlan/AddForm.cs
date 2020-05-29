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
	public partial class AddForm : DevExpress.XtraEditors.XtraForm
	{
		private readonly ProductionPlanDao  m_productionPlanDao;
		private DialogResult dialogResult;      //获取插入操作完成后MessageBox按钮值
		private readonly ProductionPlanControl m_parent;

		public AddForm()
		{
			InitializeComponent();
			m_productionPlanDao = new ProductionPlanDao();

			gridControl.DataSource = m_productionPlanDao.GetDataSource();
		}

		public AddForm(ProductionPlanControl parent)
		{
			InitializeComponent();
			m_parent = parent;
			m_productionPlanDao = new ProductionPlanDao();

			gridControl.DataSource = m_productionPlanDao.GetDataSource();
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
			Models.ProductionPlan production = new Models.ProductionPlan
			{
				BatchNo = txt_BatchNo.EditValue.ToString(),
				WorkpieceNo = txt_WorkpieceNo.EditValue.ToString(),
				WorkpieceType = txt_WorkpieceType.EditValue.ToString(),
				PrimerColor = txt_PrimerColor.EditValue.ToString(),
				PrimerFirm = txt_PrimerFirm.EditValue.ToString(),
				PrimerCraft = txt_PrimerCraft.EditValue.ToString(),
				PigmentedCoatingColor = txt_PigmentedCoatingColor.EditValue.ToString(),
				PigmentedCoatingFirm = txt_PigmentedCoatingFirm.EditValue.ToString(),
				PigmentedCoatingCraft = txt_PigmentedCoatingCraft.EditValue.ToString(),
				VarnishColor = txt_VarnishColor.EditValue.ToString(),
				VarnishFirm = txt_VarnishFirm.EditValue.ToString(),
				VarnishCraft = txt_VarnishCraft.EditValue.ToString(),
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
					m_parent.m_productionPlanList.Add(production);

					m_parent.gridControl.DataSource = m_parent.m_productionPlanList;

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
			Models.ProductionPlan model = this.gridView.GetRow(e.RowHandle) as Models.ProductionPlan;
			SetEditValues(model);
		}

		/// <summary>
		/// 设置编辑框的值
		/// </summary>
		/// <param name="model"></param>
		public void SetEditValues(Models.ProductionPlan model)
		{
			txt_BatchNo.EditValue = model.BatchNo;
			txt_PigmentedCoatingColor.EditValue = model.PigmentedCoatingColor;
			txt_PigmentedCoatingCraft.EditValue = model.PigmentedCoatingCraft;
			txt_PigmentedCoatingFirm.EditValue = model.PigmentedCoatingFirm;
			txt_PrimerColor.EditValue = model.PrimerColor;
			txt_PrimerCraft.EditValue = model.PrimerCraft;
			txt_PrimerFirm.EditValue = model.PrimerFirm;
			txt_VarnishColor.EditValue = model.VarnishColor;
			txt_VarnishCraft.EditValue = model.VarnishCraft;
			txt_VarnishFirm.EditValue = model.VarnishFirm;
			txt_WorkpieceNo.EditValue = model.WorkpieceNo;
			txt_WorkpieceType.EditValue = model.WorkpieceType;
			//date_UpTime.EditValue = string.IsNullOrEmpty(model.UpTime) ?
			//	DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") : model.UpTime;
		}
	}
}