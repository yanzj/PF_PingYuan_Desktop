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
using PF_PingYuan_Desktop.DataModels;
using PF_PingYuan_Desktop.OpcUa;
using PF_PingYuan_Desktop.Setting;

namespace PF_PingYuan_Desktop.Forms.LabelProductionInfo
{
	public partial class LabelProductionInfoControl : DevExpress.XtraEditors.XtraUserControl
	{
		private ProductionInfoDao _productionInfoDao;
		private OpcClient m_uaClient;
		private XMLSettings m_xmlSettings;

		public LabelProductionInfoControl()
		{
			InitializeComponent();
			_productionInfoDao = new ProductionInfoDao();
			m_xmlSettings = new XMLSettings();
			m_xmlSettings.ReadXMLSettings();

			m_uaClient = new OpcClient();
			//gridControl.DataSource = _productionInfoDao.GetDataSource();
		}
		void windowsUIButtonPanel_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
		{
			if (e.Button.Properties.Caption == "Print") gridControl.ShowRibbonPrintPreview();
			switch (e.Button.Properties.Caption)
			{
				case "刷新":
					List<Rack> racks = GetRacks();
					List<ProductionInfo> productionInfos = SetProductionInfoList(racks);
					gridControl.DataSource = productionInfos;
					break;
				case "导出":
					Common.ExportToXlsx(gridControl, this);
					break;
				case "清空":
					this.gridControl.DataSource = new BindingList<ProductionInfo>();
					break;
			}
		}


		public List<Rack> GetRacks()
		{
			List<Rack> racks = new List<Rack>();
			foreach (var areaNodeId in m_xmlSettings.Areas)
			{
				//LogManager.WriteLog(LogFile.Warning, $"GetRacks:AreaNo:{areaNodeId.AreaNo}");
				try
				{
					byte[] group1 = (byte[])m_uaClient.ReadData(areaNodeId.Group_1).Value;
					byte[] group2 = (byte[])m_uaClient.ReadData(areaNodeId.Group_2).Value;
					byte[] group3 = (byte[])m_uaClient.ReadData(areaNodeId.Group_3).Value;
					byte[] group4 = (byte[])m_uaClient.ReadData(areaNodeId.Group_4).Value;
					byte[] group5 = (byte[])m_uaClient.ReadData(areaNodeId.Group_5).Value;

					byte[] resArr = new byte[group1.Length + group2.Length + group3.Length + group4.Length + group5.Length];
					group1.CopyTo(resArr, 0);
					group2.CopyTo(resArr, group1.Length);
					group3.CopyTo(resArr, group1.Length + group2.Length);
					group4.CopyTo(resArr, group1.Length + group2.Length + group3.Length);
					group5.CopyTo(resArr, group1.Length + group2.Length + group3.Length + group4.Length);


					for (int i = 0; i < resArr.Length; i += 18)
					{
						Rack rack = new Rack();
						rack.AreaNo = areaNodeId.AreaNo;
						rack.RackNo = BitConverter.ToUInt16(resArr.Skip(i).Take(2).Reverse().ToArray(), 0);
						rack.BatchNo = BitConverter.ToUInt32(resArr.Skip(i + 2).Take(4).Reverse().ToArray(), 0);
						rack.WorkpieceType = resArr.Skip(i + 6).Take(4).ToArray();
						//rack.PrimerFirm = BitConverter.ToInt16(resArr.Skip(i + 8).Take(2).ToArray(), 0);
						rack.PrimerColor = BitConverter.ToUInt16(resArr.Skip(i + 10).Take(2).Reverse().ToArray(), 0);
						//rack.PrimerCraft = BitConverter.ToInt16(resArr.Skip(i + 12).Take(2).ToArray(), 0);
						//rack.PigmentedCoatingFirm = BitConverter.ToInt16(resArr.Skip(i + 14).Take(2).ToArray(), 0);
						rack.PigmentedCoatingColor = BitConverter.ToUInt16(resArr.Skip(i + 12).Take(2).Reverse().ToArray(), 0);
						//rack.PigmentedCoatingCraft = BitConverter.ToInt16(resArr.Skip(i + 18).Take(2).ToArray(), 0);
						//rack.VarnishFirm = BitConverter.ToInt16(resArr.Skip(i + 20).Take(2).ToArray(), 0);
						rack.VarnishColor = BitConverter.ToUInt16(resArr.Skip(i + 14).Take(2).Reverse().ToArray(), 0);
						//rack.VarnishCraft = BitConverter.ToInt16(resArr.Skip(i + 24).Take(2).ToArray(), 0);

						int isZero = 0;

						for (int j = 0; j < rack.WorkpieceType.Length; j++)
						{
							if (rack.WorkpieceType[j] == 0)
							{
								isZero++;
							}
						}

						if (rack.RackNo == 0 && rack.BatchNo == 0 && isZero == 4
							&& rack.PrimerColor == 0 && rack.PrimerCraft == 0 && rack.PrimerFirm == 0
							&& rack.PigmentedCoatingColor == 0 && rack.PigmentedCoatingCraft == 0
							&& rack.PigmentedCoatingFirm == 0 && rack.VarnishColor == 0
							&& rack.VarnishCraft == 0 && rack.VarnishFirm == 0)
						{
							continue;
						}

						racks.Add(rack);
					}
				}
				catch (Exception ex)
				{
					//LogManager.WriteLog(LogFile.Trace, $"GetRacks:{ex.Message}");
				}
			}
			return racks;
		}

		private List<ProductionInfo> SetProductionInfoList(List<Rack> racks)
		{
			List<ProductionInfo> productionInfos = new List<ProductionInfo>();
			try
			{

				foreach (var rack in racks)
				{
					ProductionInfo productionInfo = new ProductionInfo();
					productionInfo.AreaNo = rack.AreaNo;
					productionInfo.BatchNo = rack.BatchNo.ToString();
					productionInfo.RackNo = rack.RackNo;
					productionInfo.WorkpieceType = Encoding.ASCII.GetString(rack.WorkpieceType);
					productionInfo.PrimerColor = $"{rack.PrimerColor}";
					productionInfo.PrimerCraft = $"{rack.PrimerCraft}";
					productionInfo.PrimerFirm = $"{rack.PrimerFirm}";
					productionInfo.PigmentedCoatingColor = $"{rack.PigmentedCoatingColor}";
					productionInfo.PigmentedCoatingCraft = $"{rack.PigmentedCoatingCraft}";
					productionInfo.PigmentedCoatingFirm = $"{rack.PigmentedCoatingFirm}";
					productionInfo.VarnishCraft = $"{rack.VarnishCraft}";
					productionInfo.VarnishFirm = $"{rack.VarnishFirm}";
					productionInfo.Validity = 1;
					productionInfo.RecordTimestamp = DateTime.Now;
					productionInfo.UID = 1;
					productionInfos.Add(productionInfo);
				}
			}
			catch (Exception ex)
			{
				//LogManager.WriteLog(LogFile.Trace, ex.Message);
			}

			return productionInfos;
		}
	}
}
