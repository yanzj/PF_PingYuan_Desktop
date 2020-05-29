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
using DevExpress.DataAccess.Excel;
using System.IO;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using PF_PingYuan_Desktop.Dao;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using PF_PingYuan_Desktop.Forms.ProductionPlan.Operations;

namespace PF_PingYuan_Desktop.Forms.ProductionPlan
{
	public partial class ImportForm : DevExpress.XtraEditors.XtraForm
	{
        private ProductionPlanDao m_productionPlanDao;
        private DialogResult dialogResult;      //获取插入操作完成后MessageBox按钮值
        private DataTable m_dataTable;
        private readonly ProductionPlanControl m_parent;

        public ImportForm()
		{
			InitializeComponent();
            m_productionPlanDao = new ProductionPlanDao();
		}

		public ImportForm(ProductionPlanControl parent, string filePath)
		{
			InitializeComponent();
            m_parent = parent;
            m_productionPlanDao = new ProductionPlanDao();

			FillExcelGrid(filePath);			//充填grid
		}

		/// <summary>
		/// 将excel数据导入充填Grid
		/// </summary>
		/// <param name="filePath">需要导入的文件路径</param>
		public void FillExcelGrid(string filePath)
		{
            /*
			ExcelDataSource excelData = new ExcelDataSource();
			excelData.FileName = filePath;

			//ExcelWorksheetSettings worksheetSettings = new ExcelWorksheetSettings("Sheet1", "A1:M100");
			ExcelWorksheetSettings worksheetSettings = new ExcelWorksheetSettings("Sheet1");
			excelData.SourceOptions = new ExcelSourceOptions(worksheetSettings);

			excelData.SourceOptions.SkipEmptyRows = false;
			excelData.SourceOptions.UseFirstRowAsHeader = true;

			excelData.Fill();
            */
			m_dataTable = ExcelToTable(filePath);			

			excelGridControl.DataSource = m_dataTable;
		}

        /// <summary>
        /// 获取导入的Excel数据
        /// </summary>
        /// <param name="file">导入文件路径</param>
        /// <returns></returns>
        public DataTable ExcelToTable(string file)
        {
            DataTable dt = new DataTable();
            IWorkbook workbook;
            string fileExt = Path.GetExtension(file).ToLower();
            using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read))
            {
                //XSSFWorkbook 适用XLSX格式，HSSFWorkbook 适用XLS格式
                if (fileExt == ".xlsx") { workbook = new XSSFWorkbook(fs); } else if (fileExt == ".xls") { workbook = new HSSFWorkbook(fs); } else { workbook = null; }
                if (workbook == null) { return null; }
                ISheet sheet = workbook.GetSheetAt(0);

                //表头  
                IRow header = sheet.GetRow(sheet.FirstRowNum);
                List<int> columns = new List<int>();
                for (int i = 0; i < header.LastCellNum; i++)
                {
                    object obj = GetValueType(header.GetCell(i));
                    if (obj == null || obj.ToString() == string.Empty)
                    {
                        dt.Columns.Add(new DataColumn("Columns" + i.ToString()));
                    }
                    else
                        dt.Columns.Add(new DataColumn(obj.ToString()));
                    columns.Add(i);
                }
                //数据  
                for (int i = sheet.FirstRowNum + 1; i <= sheet.LastRowNum; i++)
                {
                    DataRow dr = dt.NewRow();
                    bool hasValue = false;
                    foreach (int j in columns)
                    {
                        dr[j] = GetValueType(sheet.GetRow(i).GetCell(j));
                        if (dr[j] != null && dr[j].ToString() != string.Empty)
                        {
                            hasValue = true;
                        }
                    }
                    if (hasValue)
                    {
                        dt.Rows.Add(dr);
                    }
                }
            }
            return dt;
        }

        /// <summary>
        /// 获取单元格类型
        /// </summary>
        /// <param name="cell"></param>
        /// <returns></returns>
        private static object GetValueType(ICell cell)
        {
            if (cell == null)
                return null;
            switch (cell.CellType)
            {
                case CellType.Blank: //BLANK:  
                    return null;
                case CellType.Boolean: //BOOLEAN:  
                    return cell.BooleanCellValue;
                case CellType.Numeric: //NUMERIC:  
                    return cell.NumericCellValue;
                case CellType.String: //STRING:  
                    return cell.StringCellValue;
                case CellType.Error: //ERROR:  
                    return cell.ErrorCellValue;
                case CellType.Formula: //FORMULA:  
                default:
                    return "=" + cell.CellFormula;
            }
        }

        /// <summary>
        /// 删除选中的行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Delete_Click(object sender, EventArgs e)
		{
			int selectedHandle = this.excelGridView.SelectedRowsCount;
			if(selectedHandle > 0)
			{
				this.excelGridView.DeleteSelectedRows();
			}
		}

        /// <summary>
        /// 导入数据库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void btn_Import_Click(object sender, EventArgs e)
		{
            List<Models.ProductionPlan> productionPlans = new List<Models.ProductionPlan>();
			Models.ProductionPlan productionPlan;
			for (int i = 0;i < this.excelGridView.RowCount;i ++)
			{
               DataRow dr = this.excelGridView.GetDataRow(i);
                productionPlan = new Models.ProductionPlan
                {
                    BatchNo = dr.ItemArray[0].ToString(),
                    WorkpieceNo = dr.ItemArray[1].ToString(),
                    WorkpieceType = dr.ItemArray[2].ToString(),
                    PrimerColor = dr.ItemArray[3].ToString(),
                    PrimerFirm = dr.ItemArray[4].ToString(),
                    PrimerCraft = dr.ItemArray[5].ToString(),
                    PigmentedCoatingColor = dr.ItemArray[6].ToString(),
                    PigmentedCoatingFirm = dr.ItemArray[7].ToString(),
                    PigmentedCoatingCraft = dr.ItemArray[8].ToString(),
                    VarnishColor = dr.ItemArray[9].ToString(),
                    VarnishFirm = dr.ItemArray[10].ToString(),
                    VarnishCraft = dr.ItemArray[11].ToString(),
                    Validity = 1,
                    UpTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    RecordTimestamp = DateTime.Now
                };

                productionPlans.Add(productionPlan);
			}

            int result = m_productionPlanDao.InsertProductionPlans(productionPlans);

            if (result > 0)
            {
                dialogResult = MessageBox.Show("添加成功");
                if (dialogResult == DialogResult.OK)
                {
                    //BindingList<Models.ProductionPlan> list = new BindingList<Models.ProductionPlan>();

                    foreach (var production in productionPlans)
                    {
                        m_parent.m_productionPlanList.Add(production);
                    }

                    m_parent.gridControl.DataSource = m_parent.m_productionPlanList;

                    /*
                    Dictionary<object, string> dicButtons = new Dictionary<object, string>();
                    dicButtons.Add("Up", "上件");
                    dicButtons.Add("Stop", "暂停");
                    dicButtons.Add("Finish", "结束");
                    RepositoryItemButtonEdit ribe = ItemOperation.CreateRepositoryItemButtonEdit(dicButtons);
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
	}
}