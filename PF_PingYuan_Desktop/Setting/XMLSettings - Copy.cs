using OpcUaClient;
using PF_PingYuan_Desktop.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PF_PingYuan_Desktop.Setting
{
	 public class XMLSettings1
	{
		public static string FileName = "Settings.xml";
		public static string FilePath;

		public const string Key_Con = "Connection";
		public const string Key_BD203NodeIdList = "DB203NodeIdList";
		public const string Key_BD202NodeIdList = "DB202NodeIdList";
		public const string Key_DataType = "DataType";
		public const string Key_Access = "Access";
		public const string Key_NodeId = "NodeId";
		public const string Key_WriteNodeId = "WriteNodeId";
		public const string Key_ReloadServer = "ReloadServer";

		public const string Key_Site_1 = "Site_1";
		public const string Key_Site_2 = "Site_2";
		public const string Key_Site_3 = "Site_3";
		public const string Key_Site_4 = "Site_4";
		public const string Key_Site_5 = "Site_5";
		public const string Key_Site_6 = "Site_6";
		public const string Key_Site_7 = "Site_7";
		public const string Key_Site_8 = "Site_8";
		public const string Key_Site_9 = "Site_9";
		public const string Key_Site_10 = "Site_10";


		//public const string Value_IP = "IP";
		public const string Value_Port = "Port";
		public const string Value_Password = "Password";
		public const string Value_NodeIdList = "NodeIdList";
		public const string Value_NodeIdIOLink = "IOLink";
		public const string Value_NodeIdSystem = "System";
		public const string Value_NodeIdIPCReceiveResult = "IPCReceiveResult";
		public const string Value_NodeCount = "NodeCount";
		public const string Value_UserName = "UserName";
		public const string Value_FilePath = "FilePath";

		#region DB203
		public const string Value_Heartbeat = "Heartbeat";
		public const string Value_WorkpieceType = "WorkpieceType";
		public const string Value_PrimerColor = "PrimerColor";
		public const string Value_PrimerFirm = "PrimerFirm";
		public const string Value_PrimerCraft = "PrimerCraft";
		public const string Value_PigmentedCoatingColor = "PigmentedCoatingColor";
		public const string Value_PigmentedCoatingFirm = "PigmentedCoatingFirm";
		public const string Value_PigmentedCoatingCraft = "PigmentedCoatingCraft";
		public const string Value_VarnishColor = "VarnishColor";
		public const string Value_VarnishFirm = "VarnishFirm";
		public const string Value_VarnishCraft = "VarnishCraft";
		public const string Value_BatchNo = "BatchNo";
		public const string Value_Receive_1 = "Receive_1";
		public const string Value_Receive_2 = "Receive_2";
		public const string Value_Receive_3 = "Receive_3";
		public const string Value_Receive_4 = "Receive_4";
		public const string Value_Receive_5 = "Receive_5";
		public const string Value_Receive_6 = "Receive_6";
		public const string Value_Receive_7 = "Receive_7";
		public const string Value_Receive_8 = "Receive_8";
		public const string Value_Receive_9 = "Receive_9";
		public const string Value_Receive_10 = "Receive_10";
		#endregion

		#region DB202
		public const string Value_Heart = "HeartBeat";
		public const string Value_FinishedLoding = "FinishedLoding";
		public const string Value_EPC = "EPC";
		public const string Value_CommunicationStatus_1 = "CommunicationStatus_1";
		public const string Value_CommunicationStatus_2 = "CommunicationStatus_2";
		public const string Value_CommunicationStatus_3 = "CommunicationStatus_3";
		public const string Value_CommunicationStatus_4 = "CommunicationStatus_4";
		public const string Value_CommunicationStatus_5 = "CommunicationStatus_5";
		public const string Value_CommunicationStatus_6 = "CommunicationStatus_6";
		public const string Value_CommunicationStatus_7 = "CommunicationStatus_7";
		public const string Value_CommunicationStatus_8 = "CommunicationStatus_8";
		public const string Value_CommunicationStatus_9 = "CommunicationStatus_9";
		public const string Value_CommunicationStatus_10 = "CommunicationStatus_10";
		#endregion

		public string URL
		{ get; set; }
		public string Port
		{ get; set; }
		public string UserName
		{ get; set; }
		public string Password
		{ get; set; }
		public string ReloadFilePath
		{ get; set; }
		public string[] NodeIdList
		{ get; set; }
		public string[] SiteNodeList { get; set; }
		public List<DB203Site> SiteNodes { get; set; }
		public string[] IOLinkList
		{ get; set; }
		public string SystemNodeId
		{ get; set; }
		public string IPCReceiveResult
		{ get; set; }
		public int NodeCount
		{ get; set; }
		public string DataType
		{ get; set; }
		public string Access
		{ get; set; }
		public string Heartbeat
		{ get; set; }
		public string WorkpieceType { get; set; }
		public string PrimerColor { get; set; }
		public string PrimerFirm { get; set; }
		public string PrimerCraft { get; set; }
		public string PigmentedCoatingColor { get; set; }
		public string PigmentedCoatingFirm { get; set; }
		public string PigmentedCoatingCraft { get; set; }
		public string VarnishColor { get; set; }
		public string VarnishFirm { get; set; }
		public string VarnishCraft { get; set; }
		public string BatchNo { get; set; }
		public string Receive_1 { get; set; }
		public string Receive_2 { get; set; }
		public string Receive_3 { get; set; }
		public string Receive_4 { get; set; }
		public string Receive_5 { get; set; }
		public string Receive_6 { get; set; }
		public string Receive_7 { get; set; }
		public string Receive_8 { get; set; }
		public string Receive_9 { get; set; }
		public string Receive_10 { get; set; }

		public string HeartBeat
		{ get; set; }
		public string Heart { get; private set; }
		public string FinishedLoding { get; set; }
		public string EPC { get; set; }

		public string CommunicationStatus_1 { get; set; }
		public string CommunicationStatus_2 { get; set; }
		public string CommunicationStatus_3 { get; set; }
		public string CommunicationStatus_4 { get; set; }
		public string CommunicationStatus_5 { get; set; }
		public string CommunicationStatus_6 { get; set; }
		public string CommunicationStatus_7 { get; set; }
		public string CommunicationStatus_8 { get; set; }
		public string CommunicationStatus_9 { get; set; }
		public string CommunicationStatus_10 { get; set; }

		public List<SiteNodeId> Sites { get; set; } 

		public XMLSettings1() 
		{ 
			FilePath = AppDomain.CurrentDomain.BaseDirectory + "Settings//" + FileName;
			Sites = new List<SiteNodeId>();
		}

		#region 读取配置文件，将相应参数填入实例对象的属性中
		/// <summary>
		/// 读取配置文件，将相应参数填入实例对象的属性中
		/// </summary>
		public void ReadXMLSettings()
		{
			try
			{
				XmlDocument xml = new XmlDocument();
				xml.Load(FilePath);
				XmlNodeList nodeListsOfRoot = xml.SelectSingleNode("Root").ChildNodes;
				SiteNodes = new List<DB203Site>();
				//Site site = new Site();
				for (int i = 0; i < nodeListsOfRoot.Count; i++)
				{
					switch (nodeListsOfRoot[i].Name)
					{
						case Key_Con:
							this.Port = nodeListsOfRoot[i].SelectSingleNode(Value_Port).InnerText;
							this.URL = "opc.tcp://" + /*GetHostIP()*/"192.168.0.197" + ":" + this.Port;
							this.UserName = nodeListsOfRoot[i].SelectSingleNode(Value_UserName).InnerText;
							this.Password = nodeListsOfRoot[i].SelectSingleNode(Value_Password).InnerText;
							break;
						case Key_ReloadServer:
							this.ReloadFilePath = nodeListsOfRoot[i].SelectSingleNode(Value_FilePath).InnerText;
							break;
						case Key_NodeId:
							this.SystemNodeId = nodeListsOfRoot[i].SelectSingleNode(Value_NodeIdSystem).InnerText;
							break;
						case Key_WriteNodeId:
							this.IPCReceiveResult = nodeListsOfRoot[i].SelectSingleNode(Value_NodeIdIPCReceiveResult).InnerText;
							break;
						case Key_BD203NodeIdList:
							this.Heartbeat = nodeListsOfRoot[i].SelectSingleNode(Value_Heartbeat).InnerText;
							this.WorkpieceType = nodeListsOfRoot[i].SelectSingleNode(Value_WorkpieceType).InnerText;
							this.PrimerColor = nodeListsOfRoot[i].SelectSingleNode(Value_PrimerColor).InnerText;
							this.PrimerFirm = nodeListsOfRoot[i].SelectSingleNode(Value_PrimerFirm).InnerText;
							this.PrimerCraft = nodeListsOfRoot[i].SelectSingleNode(Value_PrimerCraft).InnerText;
							this.PigmentedCoatingColor = nodeListsOfRoot[i].SelectSingleNode(Value_PigmentedCoatingColor).InnerText;
							this.PigmentedCoatingFirm = nodeListsOfRoot[i].SelectSingleNode(Value_PigmentedCoatingFirm).InnerText;
							this.PigmentedCoatingCraft = nodeListsOfRoot[i].SelectSingleNode(Value_PigmentedCoatingCraft).InnerText;
							this.VarnishColor = nodeListsOfRoot[i].SelectSingleNode(Value_VarnishColor).InnerText;
							this.VarnishFirm = nodeListsOfRoot[i].SelectSingleNode(Value_VarnishFirm).InnerText;
							this.VarnishCraft = nodeListsOfRoot[i].SelectSingleNode(Value_VarnishCraft).InnerText;
							this.BatchNo = nodeListsOfRoot[i].SelectSingleNode(Value_BatchNo).InnerText;
							this.Receive_1 = nodeListsOfRoot[i].SelectSingleNode(Value_Receive_1).InnerText;
							this.Receive_2 = nodeListsOfRoot[i].SelectSingleNode(Value_Receive_2).InnerText;
							this.Receive_3 = nodeListsOfRoot[i].SelectSingleNode(Value_Receive_3).InnerText;
							this.Receive_4 = nodeListsOfRoot[i].SelectSingleNode(Value_Receive_4).InnerText;
							this.Receive_5 = nodeListsOfRoot[i].SelectSingleNode(Value_Receive_5).InnerText;
							this.Receive_6 = nodeListsOfRoot[i].SelectSingleNode(Value_Receive_6).InnerText;
							this.Receive_7 = nodeListsOfRoot[i].SelectSingleNode(Value_Receive_7).InnerText;
							this.Receive_8 = nodeListsOfRoot[i].SelectSingleNode(Value_Receive_8).InnerText;
							this.Receive_9 = nodeListsOfRoot[i].SelectSingleNode(Value_Receive_9).InnerText;
							this.Receive_10 = nodeListsOfRoot[i].SelectSingleNode(Value_Receive_10).InnerText;
							break;
						case Key_BD202NodeIdList:
							this.Heart = nodeListsOfRoot[i].SelectSingleNode(Value_Heart).InnerText;
							this.FinishedLoding = nodeListsOfRoot[i].SelectSingleNode(Value_FinishedLoding).InnerText;
							this.EPC = nodeListsOfRoot[i].SelectSingleNode(Value_EPC).InnerText;
							this.CommunicationStatus_1 = nodeListsOfRoot[i].SelectSingleNode(Value_CommunicationStatus_1).InnerText;
							this.CommunicationStatus_2 = nodeListsOfRoot[i].SelectSingleNode(Value_CommunicationStatus_2).InnerText;
							this.CommunicationStatus_3 = nodeListsOfRoot[i].SelectSingleNode(Value_CommunicationStatus_3).InnerText;
							this.CommunicationStatus_4 = nodeListsOfRoot[i].SelectSingleNode(Value_CommunicationStatus_4).InnerText;
							this.CommunicationStatus_5 = nodeListsOfRoot[i].SelectSingleNode(Value_CommunicationStatus_5).InnerText;
							this.CommunicationStatus_6 = nodeListsOfRoot[i].SelectSingleNode(Value_CommunicationStatus_6).InnerText;
							this.CommunicationStatus_7 = nodeListsOfRoot[i].SelectSingleNode(Value_CommunicationStatus_7).InnerText;
							this.CommunicationStatus_8 = nodeListsOfRoot[i].SelectSingleNode(Value_CommunicationStatus_8).InnerText;
							this.CommunicationStatus_9 = nodeListsOfRoot[i].SelectSingleNode(Value_CommunicationStatus_9).InnerText;
							this.CommunicationStatus_10 = nodeListsOfRoot[i].SelectSingleNode(Value_CommunicationStatus_10).InnerText;
							break;
						case Key_Site_1:
							Sites.Add(GetSite(nodeListsOfRoot[i].ChildNodes));
							break;
						case Key_Site_2:
							Sites.Add(GetSite(nodeListsOfRoot[i].ChildNodes));
							break;
						case Key_Site_3:
							Sites.Add(GetSite(nodeListsOfRoot[i].ChildNodes));
							break;
						case Key_Site_4:
							Sites.Add(GetSite(nodeListsOfRoot[i].ChildNodes));
							break;
						case Key_Site_5:
							Sites.Add(GetSite(nodeListsOfRoot[i].ChildNodes));
							break;
						case Key_Site_6:
							Sites.Add(GetSite(nodeListsOfRoot[i].ChildNodes));
							break;
						case Key_Site_7:
							Sites.Add(GetSite(nodeListsOfRoot[i].ChildNodes));
							break;
						case Key_Site_8:
							Sites.Add(GetSite(nodeListsOfRoot[i].ChildNodes));
							break;
						case Key_Site_9:
							Sites.Add(GetSite(nodeListsOfRoot[i].ChildNodes));
							break;
						case Key_Site_10:
							Sites.Add(GetSite(nodeListsOfRoot[i].ChildNodes));
							break;
						default: break;
					}
				}
			}
			catch (Exception ex)
			{
				LogManager.WriteLog(LogFile.Trace, ex.Message);
			}

		}
		#endregion

		public SiteNodeId GetSite(XmlNodeList nodeList)
		{
			SiteNodeId site = new SiteNodeId();
			for (int j = 0; j < nodeList.Count; j++)
			{
				string node = nodeList[j].InnerText;
				if (node.EndsWith(".PT"))
				{
					site.PT = node;
				}
				else if (node.EndsWith(".RSSI"))
				{
					site.RSSI = node;
				}
				else if (node.EndsWith(".RackNo"))
				{
					site.RackNo = node;
				}
				else if (node.EndsWith(".ReadStatus"))
				{
					site.ReadStatus = node;
				}
			}
			return site;
		}

		#region 获取本机IPV4地址
		/// <summary>
		/// 获取本机IPV4地址
		/// </summary>
		/// <returns></returns>
		public static string GetHostIP()
		{
			string hostname = Dns.GetHostName();
			IPHostEntry localentry = Dns.GetHostEntry(hostname);
			IPAddress localaddress = localentry.AddressList.FirstOrDefault(d => d.AddressFamily.ToString().Equals("InterNetwork"));
			//IPAddress localaddress = localentry.AddressList[0]; 
			return localaddress.ToString();
		}
		#endregion
	}
}
