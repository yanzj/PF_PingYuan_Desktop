using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PF_PingYuan_Desktop.Forms
{
	public class Common
	{
		public static void ExportToXlsx(DevExpress.XtraGrid.GridControl gridControl, UserControl usercontrol)
		{
			SaveFileDialog fileDialog = new SaveFileDialog();
			fileDialog.Title = "导出Excel";
			fileDialog.Filter = "Excel文件(*.xlsx)|*.xlsx";
			DialogResult dialogResult = fileDialog.ShowDialog(usercontrol);
			if (dialogResult == DialogResult.OK)
			{
				DevExpress.XtraPrinting.XlsExportOptions options = new
				DevExpress.XtraPrinting.XlsExportOptions();
				gridControl.ExportToXlsx(fileDialog.FileName);
				DevExpress.XtraEditors.XtraMessageBox.Show("保存成功！", "提示",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}
