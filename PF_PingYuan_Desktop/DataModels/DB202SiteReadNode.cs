using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF_PingYuan_Desktop.DataModels
{
	public class DB202SiteReadNode
	{
		/// <summary>
		/// 站点号
		/// </summary>
		public int SiteNo { get; set; }

		/// <summary>
		/// 心跳
		/// </summary>
		public string Heartbeat { get; set; }


		/// <summary>
		/// EPC码
		/// </summary>
		public string EPC { get; set; }

		/// <summary>
		/// 读取功率
		/// </summary>
		public string PT { get; set; }

		/// <summary>
		/// 信号强度
		/// </summary>
		public string RSSI { get; set; }

		/// <summary>
		/// 挂具号
		/// </summary>
		public string RackNo { get; set; }

		/// <summary>
		/// 读取状态
		/// </summary>
		public string ReadStatus { get; set; }

		/// <summary>
		/// 站点通信状态
		/// </summary>
		public string CommunicationStatus { get; set; }

		/// <summary>
		/// 返回状态
		/// </summary>
		public string RFIDReturnStatus { get; set; }
	}
}
