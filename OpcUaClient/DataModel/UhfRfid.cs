using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpcUaClient.DataModel
{
	public class UhfRfid
	{
		/// <summary>
		/// UHF RFID数据载体EPC码
		/// </summary>
		public string EPC { get; set; }

		/// <summary>
		/// 挂具号
		/// </summary>
		public int RackNo { get; set; }

		#region 读写数据载体是，读写头工作参数
		/// <summary>
		/// 发射功率
		/// </summary>
		public int TransmitPower { get; set; }

		/// <summary>
		/// 极化方向
		/// </summary>
		public decimal PolarisationDirection { get; set; }

		/// <summary>
		/// RSSI
		/// </summary>
		public byte RSSI { get; set; }

		/// <summary>
		/// 站点编号
		/// </summary>
		public int SiteNo { get; set; }
		#endregion

		/// <summary>
		/// PLC FB程序尝试读写次数
		/// </summary>
		public int ReadWriteTimes { get; set; }

		/// <summary>
		/// 对应烘干室的温度
		/// </summary>
		public float DryingRoomTemperature { get; set; }

		/// <summary>
		/// 当前记录的时间戳
		/// </summary>
		public DateTime RecordTimestamp { get; set; }

		/// <summary>
		/// 当前记录的UID
		/// </summary>
		public int UID { get; set; }
	}
}
