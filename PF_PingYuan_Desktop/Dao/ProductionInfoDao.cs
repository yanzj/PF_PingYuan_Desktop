using OpcUaClient;
using PF_PingYuan_Desktop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF_PingYuan_Desktop.Dao
{
	public class ProductionInfoDao : BaseDao
	{
		public BindingList<ProductionInfo> GetDataSource()
		{
			BindingList<ProductionInfo> result = new BindingList<ProductionInfo>();
			List<ProductionInfo> list = _context.ProductionInfos.ToList();

			for (int i = 0; i < list.Count; i++)
			{
				result.Add(list[i]);
			}

			return result;
		}

		public BindingList<ProductionInfo> FindDataSourceByUpTime(string startTime, string endTime)
		{
			BindingList<ProductionInfo> result = new BindingList<ProductionInfo>();
			try
			{
				DateTime minTime = Convert.ToDateTime(startTime);
				DateTime maxTime = Convert.ToDateTime(endTime);
				List<ProductionInfo> list = _context.ProductionInfos.
					Where(p =>  DateTime.Compare(p.RecordTimestamp,minTime) >= 0
											&& DateTime.Compare(p.RecordTimestamp,maxTime) <= 0).ToList();

				for (int i = 0; i < list.Count; i++)
				{
					result.Add(list[i]);
				}
			}
			catch(Exception ex)
			{
				LogManager.WriteLog(LogFile.SQL,ex.Message);
			}
			return result;
		}

		public int InsertProductionInfos(List<ProductionInfo> productionInfos)
		{
			int result = 0;
			try
			{
				foreach (var info in productionInfos)
				{
					_context.ProductionInfos.Add(info);
				}
				result = _context.SaveChanges();
			}
			catch(Exception ex)
			{
				LogManager.WriteLog(LogFile.SQL,ex.Message);
			}
			return result;
		}

	}
}
