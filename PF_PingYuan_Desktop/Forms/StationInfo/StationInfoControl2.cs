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
using PF_PingYuan_Desktop.Dao;
using Opc.Ua;
using PF_PingYuan_Desktop.OpcUa;
using PF_PingYuan_Desktop.Setting;

namespace PF_PingYuan_Desktop.Forms.StationInfo
{
	public partial class StationInfoControl2 : DevExpress.XtraEditors.XtraUserControl
	{

		private AddWorkstationDao m_AddWorkstationDao;
		private OpcClient opcClient;
		private XMLSettings m_xmlSettings;

		public StationInfoControl2()
		{
			InitializeComponent();

			opcClient = new OpcClient();

			m_xmlSettings = new XMLSettings();
			m_xmlSettings.ReadXMLSettings();

			GetDataValue();
		}

		void windowsUIButtonPanel_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
		{
			if (e.Button.Properties.Caption == "刷新") GetDataValue();
		}

		private void GetDataValue()
		{
			m_AddWorkstationDao = new AddWorkstationDao();

			List<Models.AddWorkstation> addWorkstations = m_AddWorkstationDao.GetDataSource2();
			gridControl.DataSource = addWorkstations;

			DataValue dv = opcClient.ReadData(m_xmlSettings.TotalNum);

			if (addWorkstations != null && addWorkstations.Count > 0)
			{
				Models.AddWorkstation addWorkstation = addWorkstations.FirstOrDefault(a => a.AreaNo == 1) ?? new Models.AddWorkstation();
				this.txtBox_BatchNo.Text = addWorkstation.BatchNo;
				this.txtBox_LoadCount.Text = dv.Value.ToString();
				this.txtBox_PrimerColor.Text = addWorkstation.PrimerColor;
				this.txtBox_PigmentedCoatingColor.Text = addWorkstation.PigmentedCoatingColor;
				this.txtBox_VarnishColor.Text = addWorkstation.VarnishColor;
			}
		}
		
	}
}
