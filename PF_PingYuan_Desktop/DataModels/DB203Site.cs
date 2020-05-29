using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF_PingYuan_Desktop.DataModels
{
	public class DB203Site
	{
		/// <summary>
		/// 心跳
		/// </summary>
		public byte Heartbeat { get; set; }

        /// <summary>
        /// 工件类型
        /// </summary>
        public byte[] WorkpieceType { get; set; }

        /// <summary>
        /// 底漆颜色
        /// </summary>
        public short PrimerColor { get; set; }

        /// <summary>
        /// 底漆厂商
        /// </summary>
        public short PrimerFirm { get; set; }

        /// <summary>
        /// 底漆工艺
        /// </summary>
        public short PrimerCraft { get; set; }

        /// <summary>
        /// 色漆颜色
        /// </summary>
        public short PigmentedCoatingColor { get; set; }

        /// <summary>
        /// 色漆厂商
        /// </summary>
        public short PigmentedCoatingFirm { get; set; }

        /// <summary>
        /// 色漆工艺
        /// </summary>
        public short PigmentedCoatingCraft { get; set; }

        /// <summary>
        /// 清漆颜色
        /// </summary>
        public short VarnishColor { get; set; }

        /// <summary>
        /// 清漆厂商
        /// </summary>
        public short VarnishFirm { get; set; }

        /// <summary>
        /// 清漆工艺
        /// </summary>
        public short VarnishCraft { get; set; }

        /// <summary>
        /// 批次
        /// </summary>
        public uint BatchNo { get; set; }

        /// <summary>
        /// 1#站点数据接收完成
        /// </summary>
        public byte Receive_1 { get; set; }

        /// <summary>
        /// 2#站点数据接收完成
        /// </summary>
        public byte Receive_2 { get; set; }
        
        /// <summary>
        /// 3#站点数据接收完成
        /// </summary>
        public byte Receive_3 { get; set; }
        
        /// <summary>
        /// 3#站点数据接收完成
        /// </summary>
        public byte Receive_4 { get; set; }
        
        /// <summary>
        /// 5#站点数据接收完成
        /// </summary>
        public byte Receive_5 { get; set; }
        
        /// <summary>
        /// 1#站点数据接收完成
        /// </summary>
        public byte Receive_6 { get; set; }
        
        /// <summary>
        /// 1#站点数据接收完成
        /// </summary>
        public byte Receive_7 { get; set; }
        
        /// <summary>
        /// 8#站点数据接收完成
        /// </summary>
        public byte Receive_8 { get; set; }
        
        /// <summary>
        /// 9#站点数据接收完成
        /// </summary>
        public byte Receive_9 { get; set; }
        
        /// <summary>
        /// 10#站点数据接收完成
        /// </summary>
        public byte Receive_10 { get; set; }

        public ushort TotalNum { get; set; }
    }
}
