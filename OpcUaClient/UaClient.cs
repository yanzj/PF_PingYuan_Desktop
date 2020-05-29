using Opc.Ua;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpcUaClient
{
	public class UaClient
	{
		public OpcUaHelper.OpcUaClient opcUaClient;
		//public OpcUaClient.Setings settings;
		public static bool OpcConnected = false;//与OPC Server的连接状态
		public static List<byte[]> ProductionRecorBuffList = new List<byte[]>();
		public static byte[] IOLinkRecorBuff = new byte[0];
		public static byte[] SystemWatchBuff = new byte[0];
		public static DateTime localCacheModifiedTime = new DateTime();//记录数据更新的时间戳
		public static byte SetPLC = 0; //设置PLC读取成功位
		public static string SignalQuality = "";
		public static int ReConnectCouter = 0;//OPC重连异常计数
		public static int PLCException = 0;//OPC信号质量异常计数
		public static int SystemStatusRecordCount = 61;//系统更新计数，用于决定是否插入系统历史表
		public static bool CouldDealWithSystemTable = false;//用于决定是否可以开始操作系统表
		public static string IPCReceiveResultNodeId = "";

		public UaClient()
		{
			opcUaClient = new OpcUaHelper.OpcUaClient();
		}

		#region 无用户名密码登陆，前提服务器登陆不需要用户名密码
		/// <summary>
		/// 无用户名密码登陆，前提服务器登陆不需要用户名密码
		/// </summary>
		/// <param name="opcServerURL">opc服务的url</param>
		/// <returns></returns>
		public bool ConnectOpcServerWithNoPwd(string opcServerURL)
		{
			bool conStatus = false;
			opcUaClient.UserIdentity = new UserIdentity();
			Task t1 = opcUaClient.ConnectServer(opcServerURL);
			Task.WaitAll(t1);
			if (t1.Status == TaskStatus.RanToCompletion)
			{
				conStatus = true;
			}
			else
			{
				conStatus = false;
			}

			return conStatus;
		}
		#endregion

		#region 用户名密码登陆，前提服务器已设置用户名密码
		/// <summary>
		/// 用户名密码登陆，前提服务器已设置用户名密码
		/// </summary>
		/// <param name="opcServerURL"></param>
		/// <param name="userName"></param>
		/// <param name="pwd"></param>
		/// <returns></returns>
		public bool ConnectOpcServerWithPwd(string opcServerURL, string userName, string pwd)
		{
			bool conStatus = false;
			try
			{
				opcUaClient.UserIdentity = new UserIdentity(userName, pwd);
				Task t1 = opcUaClient.ConnectServer(opcServerURL);
				Task.WaitAll(t1);
				if(t1.Status == TaskStatus.RanToCompletion)
				{
					conStatus = true;
				}
				else
				{
					conStatus = false;
				}
			}
			catch (Exception ex)
			{
				LogManager.WriteLog(LogFile.Trace, ex.Message);
			}
			return conStatus;
		}
		#endregion

		#region 根据提供的nodeID读取相应的OPC节点值
		/// <summary>
		/// 根据提供的nodeID读取相应的OPC节点值
		/// </summary>
		/// <param name="nodeId"></param>
		/// <returns></returns>
		public string ReadDataFromOpcServer(string nodeId)
		{
			try
			{
				NodeId node = new NodeId(nodeId);
				DataValue dv = opcUaClient.ReadNode(node);
				return dv.WrappedValue.Value.ToString();
			}
			catch (Exception ex)
			{
				LogManager.WriteLog(LogFile.Trace, ex.Message);
				
			}
			return "0";
		}
		#endregion

		#region 
		public DataValue ReadData(string nodeId)
		{
			DataValue dv = null;
			try
			{
				NodeId node = new NodeId(nodeId);
				dv = opcUaClient.ReadNode(node);
			}
			catch (Exception ex)
			{
				LogManager.WriteLog(LogFile.Trace, $"ReadData:{nodeId}:{ex.Message}");
				//return "ReadFail:" + ex.Message;
			}
			return dv;
		}
			#endregion

			#region 根据提供的nodeID读取相应的OPC节点值
			/// <summary>
			/// 根据提供的nodeID读取相应的OPC节点值
			/// </summary>
			/// <param name="nodeId"></param>
			/// <returns></returns>
			public async Task<Dictionary<string, string>> ReadDataFromOpcServerAsync(string[] nodeIdArr)
		{
			//List<string> dvList = new List<string>();
			Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
			try
			{
				//List<NodeId> nodeIds = new List<NodeId>();
				for (int i = 0;  i < nodeIdArr.Length ;i++)
				{
					//nodeIds.Add(new NodeId(nodeIdArr[i]));
					int lastIndex = nodeIdArr[i].LastIndexOf('.');
					string key = nodeIdArr[i].Substring(lastIndex);
					NodeId node = new NodeId(nodeIdArr[i]);
					DataValue dv = opcUaClient.ReadNode(node);
					string value = dv.WrappedValue.Value == null ? "" : dv.WrappedValue.Value.ToString();
					//dvList.Add(value);
					keyValuePairs.Add(key,value);
				}
				//List<DataValue> dataValues = await opcUaClient.ReadNodesAsync(nodeIds.ToArray());
				//return dataValues;
			}
			catch (Exception ex)
			{
				LogManager.WriteLog(LogFile.Trace, ex.Message);
				throw new Exception(ex.Message);
			}
			return keyValuePairs;
		}
		#endregion

		#region 根据提供的opcparam，写入对应值到OPC Server，并返回操作结果
		public int WriteDataToOpcServer()
		{
			return 0;
		}
		#endregion

		#region 根据提供的nodeID及字符串，写入对应值到OPC Server
		/// <summary>
		/// 根据提供的nodeID及字符串，写入对应值到OPC Server
		/// </summary>
		/// <param name="nodeID"></param>
		/// <param name="data"></param>
		/// <returns></returns>
		public bool WriteStrDataToOpcServer(string nodeID, string data)
		{
			bool retValue = false;
			byte[] value = Encoding.Default.GetBytes(data);
			try
			{
				retValue = opcUaClient.WriteNode<byte[]>(nodeID, value);
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
				LogManager.WriteLog(LogFile.Trace, ex.Message);
				return false;
			}
		}
		#endregion

		#region 泛型函数,根据提供的nodeID及字符串，写入对应值到OPC Server
		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="nodeID"></param>
		/// <param name="data"></param>
		/// <returns></returns>
		public bool WriteDataToOpcServer<T>(string nodeID, T data)
		{
			bool retValue = false;
			//byte[] value = Encoding.Default.GetBytes(data);
			try
			{
				retValue = opcUaClient.WriteNode<T>(nodeID, data);
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

		#region 泛型函数,根据提供的nodeID及字符串，写入对应值到OPC Server,异步编程
		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="nodeID"></param>
		/// <param name="data"></param>
		/// <returns></returns>
		public async Task<bool> WriteDataToOpcServerAsync<T>(string nodeID, T data)
		{
			bool retValue = false;
			//byte[] value = Encoding.Default.GetBytes(data);
			try
			{
				retValue = await opcUaClient.WriteNodeAsync<T>(nodeID, data);
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
				LogManager.WriteLog(LogFile.Trace, ex.Message);
				return false;
			}
		}
		#endregion

		#region 根据提供的nodeIDArray写入对应值到OPC Server
		public bool WriteDataListToOpcServer(string[] nodeIDArray, List<byte>[] dataArray)
		{
			bool retValue = false;
			int writeSuccessCount = 0;
			try
			{
				for (int i = 0; i < nodeIDArray.Length; i++)
				{
					retValue = opcUaClient.WriteNode<byte[]>(nodeIDArray[i], (byte[])dataArray[i].ToArray());
					if (retValue)
						writeSuccessCount++;
				}
				if (writeSuccessCount == nodeIDArray.Length)
				{
					return true;
				}
				else
				{
					//只有全部写入成功才会返回True。
					return false;
				}
				//retValue = opcUaClient.WriteNodes(nodeIDArray, dataArray);
				//此为批量写入数据，连接正常的情况下数据可以写入成功。但是会报BadSecure异常，这里使用循环单次写入方式
			}
			catch (Exception ex)
			{
				LogManager.WriteLog(LogFile.Trace, ex.Message);
				return false;
			}
		}
		#endregion
	}
}
