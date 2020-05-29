using Opc.Ua;
using OpcUaClient;
using PF_PingYuan_Desktop.Dao;
using PF_PingYuan_Desktop.DataModels;
using PF_PingYuan_Desktop.Models;
using PF_PingYuan_Desktop.Setting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PF_PingYuan_Desktop.OpcUa
{
	public class OpcClient
	{
		private XMLSettings xmlSettings;
		private Dictionary<string, string> db203Site_KeyValue;
		private List<string> db202SiteList;
		private DB202Site dB202Site;
		private OpcUaClient.UaClient m_uaClient;
		private ProductionInfoDao m_productionInfoDao;
		private StatusInfoDao m_statusInfoDao;
		private bool opcContected = false;

		public OpcClient()
		{
			xmlSettings = new XMLSettings();
			m_productionInfoDao = new ProductionInfoDao();
			m_statusInfoDao = new StatusInfoDao();
			m_uaClient = new UaClient();
			db203Site_KeyValue = new Dictionary<string, string>();

			xmlSettings.ReadXMLSettings();
			db203Site_KeyValue.Add("Heartbeat", xmlSettings.Heartbeat);
			db203Site_KeyValue.Add("WorkpieceType", xmlSettings.WorkpieceType);
			db203Site_KeyValue.Add("PrimerColor", xmlSettings.PrimerColor);
			db203Site_KeyValue.Add("PrimerCraft", xmlSettings.PrimerCraft);
			db203Site_KeyValue.Add("PrimerFirm", xmlSettings.PrimerFirm);
			db203Site_KeyValue.Add("PigmentedCoatingColor", xmlSettings.PigmentedCoatingColor);
			db203Site_KeyValue.Add("PigmentedCoatingCraft", xmlSettings.PigmentedCoatingCraft);
			db203Site_KeyValue.Add("PigmentedCoatingFirm", xmlSettings.PigmentedCoatingFirm);
			db203Site_KeyValue.Add("VarnishColor", xmlSettings.VarnishColor);
			db203Site_KeyValue.Add("VarnishCraft", xmlSettings.VarnishCraft);
			db203Site_KeyValue.Add("VarnishFirm", xmlSettings.VarnishFirm);
			db203Site_KeyValue.Add("BatchNo", xmlSettings.BatchNo);
			db203Site_KeyValue.Add("Receive_1", xmlSettings.Receive_1);
			db203Site_KeyValue.Add("Receive_2", xmlSettings.Receive_2);
			db203Site_KeyValue.Add("Receive_3", xmlSettings.Receive_3);
			db203Site_KeyValue.Add("Receive_4", xmlSettings.Receive_4);
			db203Site_KeyValue.Add("Receive_5", xmlSettings.Receive_5);
			db203Site_KeyValue.Add("Receive_6", xmlSettings.Receive_6);
			db203Site_KeyValue.Add("Receive_7", xmlSettings.Receive_7);
			db203Site_KeyValue.Add("Receive_8", xmlSettings.Receive_8);
			db203Site_KeyValue.Add("Receive_9", xmlSettings.Receive_9);
			db203Site_KeyValue.Add("Receive_10", xmlSettings.Receive_10);
			db203Site_KeyValue.Add("TotalNum", xmlSettings.TotalNum);

			//m_uaClient = new OpcUaClient.UaClient();
		}

		/// <summary>
		/// 设置DB203站点接受是否完成
		/// </summary>
		/// <param name="i"></param>
		/// <param name="data"></param>
		/// <returns></returns>
		public bool WriteDataToOpcServer(int i, byte data)
		{
			OpcUaClient.UaClient uaClient = new OpcUaClient.UaClient();

			bool isContected = uaClient.ConnectOpcServerWithPwd(xmlSettings.URL, xmlSettings.UserName, xmlSettings.Password);
			bool retVal = false;
			string nodeId = "";

			switch (i)
			{
				case 1:
					nodeId = xmlSettings.Receive_1;
					break;
				case 2:
					nodeId = xmlSettings.Receive_2;
					break;
				case 3:
					nodeId = xmlSettings.Receive_3;
					break;
				case 4:
					nodeId = xmlSettings.Receive_4;
					break;
				case 5:
					nodeId = xmlSettings.Receive_5;
					break;
				case 6:
					nodeId = xmlSettings.Receive_6;
					break;
				case 7:
					nodeId = xmlSettings.Receive_7;
					break;
				case 8:
					nodeId = xmlSettings.Receive_8;
					break;
				case 9:
					nodeId = xmlSettings.Receive_9;
					break;
				case 10:
					nodeId = xmlSettings.Receive_10;
					break;
			}

			if (isContected && !string.IsNullOrEmpty(nodeId))
			{
				retVal = uaClient.WriteDataToOpcServer<byte>(nodeId, data);
			}
			return retVal;
		}

		#region 根据提供的nodeID及字符串，写入对应值到OPC Server
		/// <summary>
		/// 根据提供的nodeID及字符串，写入对应值到OPC Server
		/// </summary>
		/// <param name="nodeID"></param>
		/// <param name="data"></param>
		/// <returns></returns>
		public bool WriteStrDataToOpcServer(string nodeID, string data)
		{
			if (!opcContected)
			{
				opcContected = m_uaClient.ConnectOpcServerWithPwd(xmlSettings.URL, xmlSettings.UserName, xmlSettings.Password);
			}
			bool retValue = false;
			short value = Convert.ToInt16(data);
			try
			{
				//retValue = m_uaClient.WriteNode<short>(nodeID, value);
				retValue = m_uaClient.WriteDataToOpcServer<short>(nodeID, value);
				if (retValue)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			catch (Exception ex)
			{
				LogManager.WriteLog(LogFile.Error, $"{nodeID}:{ex.Message}");
				return false;
			}
		}

		#endregion

		public bool WriteDataToOpcServer(string nodeId, ushort data)
		{
			if (!opcContected)
			{
				opcContected = m_uaClient.ConnectOpcServerWithPwd(xmlSettings.URL, xmlSettings.UserName, xmlSettings.Password);
			}

			return m_uaClient.WriteDataToOpcServer<ushort>(nodeId, data);
		}

		public bool WriteDataToOpcServer(string nodeId, byte data)
		{
			if (!opcContected)
			{
				opcContected = m_uaClient.ConnectOpcServerWithPwd(xmlSettings.URL, xmlSettings.UserName, xmlSettings.Password);
			}

			return m_uaClient.WriteDataToOpcServer<byte>(nodeId, data);
		}

		public void WriteDataToOpcServer(ProductionPlan production)
		{
			if (!opcContected)
			{
				opcContected = m_uaClient.ConnectOpcServerWithPwd(xmlSettings.URL, xmlSettings.UserName, xmlSettings.Password);
			}

			DB203Site siteNode = SetDB203Site(production);

			foreach (var pi in siteNode.GetType().GetProperties())
			{
				string name = pi.Name;//获得属性的名字,后面就可以根据名字判断来进行些自己想要的操作
				var value = pi.GetValue(siteNode, null);//用pi.GetValue获得值
				Type t = pi.GetType();

				bool retValue = false;

				switch (pi.PropertyType.Name)
				{
					case "Byte":
						retValue = m_uaClient.WriteDataToOpcServer<byte>(db203Site_KeyValue[name], (byte)value);
						break;
					case "Int16":
						retValue = m_uaClient.WriteDataToOpcServer<short>(db203Site_KeyValue[name], (short)value);
						break;
					case "UInt16":
						retValue = m_uaClient.WriteDataToOpcServer<ushort>(db203Site_KeyValue[name], (ushort)value);
						break;
					case "UInt32":
						retValue = m_uaClient.WriteDataToOpcServer<uint>(db203Site_KeyValue[name], (uint)value);
						break;
					case "Byte[]":
						//retValue = m_uaClient.WriteDataToOpcServer<byte[]>(db203Site_KeyValue[name], (byte[])value);
						retValue = m_uaClient.WriteDataToOpcServer<byte[]>(db203Site_KeyValue[name], (byte[])value);
						break;
					case "byte[]":
						retValue = m_uaClient.WriteDataToOpcServer<byte[]>(db203Site_KeyValue[name], (byte[])value);
						break;
				}
			}
		}

		private DB203Site SetDB203Site(ProductionPlan production)
		{
			byte[] workpieceType = new byte[4];
			//byte[] workpiece = new ASCIIEncoding().GetBytes(production.WorkpieceType.ToUpper());
			if (production.WorkpieceType != "0")
			{
				byte[] workpiece = Encoding.Default.GetBytes(production.WorkpieceType.ToUpper());

				for (int i = 0; i < workpiece.Length; i++)
				{
					workpieceType[i] = workpiece[i];
				}
			}
			DB203Site dB203Site = new DB203Site
			{
				Heartbeat = 13,
				WorkpieceType = workpieceType,
				//WorkpieceType = Convert.ToUInt32(production.WorkpieceType),
				PrimerColor = Convert.ToInt16(production.PrimerColor),
				PrimerFirm = Convert.ToInt16(production.PrimerFirm),
				PrimerCraft = Convert.ToInt16(production.PrimerCraft),
				PigmentedCoatingColor = Convert.ToInt16(production.PigmentedCoatingColor),
				PigmentedCoatingFirm = Convert.ToInt16(production.PigmentedCoatingFirm),
				PigmentedCoatingCraft = Convert.ToInt16(production.PigmentedCoatingCraft),
				VarnishColor = Convert.ToInt16(production.VarnishColor),
				VarnishFirm = Convert.ToInt16(production.VarnishFirm),
				VarnishCraft = Convert.ToInt16(production.VarnishCraft),
				BatchNo = Convert.ToUInt32(production.BatchNo),
				Receive_1 = 0,
				Receive_2 = 0,
				Receive_3 = 0,
				Receive_4 = 0,
				Receive_5 = 0,
				Receive_6 = 0,
				Receive_7 = 0,
				Receive_8 = 0,
				Receive_9 = 0,
				Receive_10 = 0,
				TotalNum = Convert.ToUInt16(production.TotalNum)
			};

			return dB203Site;
		}

		public short ReadDataFromOpcServer(string nodeId)
		{
			short result = 0;
			try
			{
				result = Convert.ToInt16(m_uaClient.ReadDataFromOpcServer(nodeId));
			}
			catch (Exception ex)
			{
				LogManager.WriteLog(LogFile.Trace, $"ReadDataFromOpcServer出错:{ex.Message}");
			}
			return result;
		}

		public DataValue ReadData(string nodeId)
		{
			if (!opcContected)
			{
				opcContected = m_uaClient.ConnectOpcServerWithPwd(xmlSettings.URL, xmlSettings.UserName, xmlSettings.Password);
			}

			DataValue dv = m_uaClient.ReadData(nodeId);
			return dv;
		}
	}
}
