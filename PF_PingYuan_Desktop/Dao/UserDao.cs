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
	public class UserDao : BaseDao
	{
		private readonly PingYuanDbContext _context;

		public UserDao()
		{
			_context = new PingYuanDbContext();
		}

		public BindingList<User> GetDataSource()
		{
			BindingList<User> result = new BindingList<User>();
			List<User> list = _context.Users.ToList();

			for (int i = 0; i < list.Count; i++)
			{
				result.Add(list[i]);
			}
			return result;
		}

		public User FindUserById(string jobNo)
		{
			User user = null;
			try
			{
				user = _context.Users.FirstOrDefault(u => u.JobNo == jobNo);
			}
			catch(Exception ex)
			{
				LogManager.WriteLog(LogFile.SQL,ex.Message);
			}
			return user;
		}

		public User FindUser(string username, string pwd)
		{
			User user = null;
			try
			{
				 user = _context.Users.FirstOrDefault(u => u.UserName == username && u.Password == pwd);
			}
			catch (Exception ex)
			{
				LogManager.WriteLog(LogFile.SQL, ex.Message);
			}

			return user;
		}

		public int InsertUser(User user)
		{
			int result = 0;

			try
			{
				_context.Users.Add(user);
				result = _context.SaveChanges();
			}
			catch(Exception ex)
			{
				LogManager.WriteLog(LogFile.SQL, ex.Message);
			}
			return result;
		}

		public int UpdateUser(User user)
		{
			int result = 0;

			try
			{
				User userInfo = _context.Users.FirstOrDefault(u => u.JobNo == user.JobNo);
				
				result = _context.SaveChanges();
			}
			catch (Exception ex)
			{
				LogManager.WriteLog(LogFile.SQL, ex.Message);
			}
			return result;
		}
	}
}
