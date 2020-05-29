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
using NPOI.SS.Formula.Functions;

namespace PF_PingYuan_Desktop.Forms.HistoricalProduction
{
	public partial class HistoricalProductionControl : DevExpress.XtraEditors.XtraUserControl
	{
		private readonly ProductionPlanDao _productionPlanDao;
		public HistoricalProductionControl()
		{
			InitializeComponent();
			_productionPlanDao = new ProductionPlanDao();

			string nowDay = DateTime.Now.ToString("yyyy-MM-dd");
			dateEdit_Start.EditValue = $"{nowDay} 00:00:00";
			dateEdit_End.EditValue = $"{nowDay} 23:59:59";

			string startTime = Convert.ToDateTime(dateEdit_Start.EditValue).ToString("yyyy-MM-dd HH:mm:ss");
			string endTime = Convert.ToDateTime(dateEdit_End.EditValue).ToString("yyyy-MM-dd HH:mm:ss");
			gridControl.DataSource = _productionPlanDao.FindByDateTime(startTime, endTime);
		}
		void windowsUIButtonPanel_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
		{
			if (e.Button.Properties.Caption == "Print") gridControl.ShowRibbonPrintPreview();
			switch (e.Button.Properties.Caption)
			{
				case "查询":
					if (dateEdit_Start.EditValue == null
						|| dateEdit_End.EditValue == null)
					{
						this.gridControl.DataSource = _productionPlanDao.GetDataSource();
						break;
					}
					string startTime = Convert.ToDateTime(dateEdit_Start.EditValue).ToString("yyyy-MM-dd HH:mm:ss");
					string endTime = Convert.ToDateTime(dateEdit_End.EditValue).ToString("yyyy-MM-dd HH:mm:ss");
					this.gridControl.DataSource = _productionPlanDao.FindByDateTime(startTime,endTime);
					break;
				case "导出":
					Common.ExportToXlsx(gridControl,this);
					break;
				case "清空":
					this.gridControl.DataSource = new BindingList<Models.ProductionPlan>();
					break;
			}
		}
	}
}
