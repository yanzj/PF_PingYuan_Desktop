using OpcUaClient;
using PF_PingYuan_Desktop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF_PingYuan_Desktop.Dao
{
	public class StatusInfoDao : BaseDao
	{
		public int InsertStatusInfo(StatusInfo statusInfo)
		{
			int result = 0;

			try
			{
				if (_context.StatusInfos.ToList().Count != 0)
				{
					int maxId = _context.StatusInfos.Max(s => s.Id);
					statusInfo.Id = maxId + 1;
				}
				else
				{
					statusInfo.Id = 1;
				}
				_context.StatusInfos.Add(statusInfo);
				_context.SaveChanges();
			}
			catch(Exception ex)
			{
				LogManager.WriteLog(LogFile.SQL,ex.Message);
			}

			return result;
		}
	}
}
