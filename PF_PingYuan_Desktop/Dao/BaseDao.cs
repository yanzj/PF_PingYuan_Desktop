using PF_PingYuan_Desktop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF_PingYuan_Desktop.Dao
{
	public class BaseDao
	{
		public PingYuanDbContext _context;

		public BaseDao()
		{
			_context = new PingYuanDbContext();
		}
	}
}
