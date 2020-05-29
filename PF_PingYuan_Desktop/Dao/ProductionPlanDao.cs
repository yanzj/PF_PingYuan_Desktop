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
	public class ProductionPlanDao : BaseDao
	{
        public BindingList<Models.ProductionPlan> GetDataSource()
        {

            BindingList<Models.ProductionPlan> result = new BindingList<Models.ProductionPlan>();
            using (PingYuanDbContext context = new PingYuanDbContext())
            {
                List<Models.ProductionPlan> list = context.ProductionPlans.ToList();

                for (int i = 0; i < list.Count; i++)
                {
                    result.Add(list[i]);
                }
            }
                

            return result;
        }

        public BindingList<Models.ProductionPlan> GetDataSource(string batchNo)
        {
            BindingList<Models.ProductionPlan> result = new BindingList<Models.ProductionPlan>();
            using (PingYuanDbContext context = new PingYuanDbContext())
            {
                List<Models.ProductionPlan> list = context.ProductionPlans.
                Where(p => p.BatchNo == batchNo).ToList();

                for (int i = 0; i < list.Count; i++)
                {
                    result.Add(list[i]);
                }
            }
            return result;
        }

        public List<Models.ProductionPlan> GetDataSourceList(string batchNo)
        {
            List<Models.ProductionPlan> list = new List<ProductionPlan>();
            using (PingYuanDbContext context = new PingYuanDbContext())
            {
                list = context.ProductionPlans.
                Where(p => p.BatchNo == batchNo).ToList();

            }
            return list;
        }

        public int InsertProductionPlan(ProductionPlan productionPlan )
        {
            int result = 0;
            try
            {
                //if (_context.ProductionPlans.FirstOrDefault(p => p.BatchNo == productionPlan.BatchNo) == null)
                //{
                using (PingYuanDbContext context = new PingYuanDbContext()) 
                { 
                    context.ProductionPlans.Add(productionPlan);
                    result = context.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"InsertProductionPlan出错:{ex.Message}");
            }
            return result;
        }

        public int InsertProductionPlans(List<ProductionPlan> productionPlans)
        {
            int result = 0;
            using (PingYuanDbContext context = new PingYuanDbContext())
            {
                try
                {
                    foreach (var production in productionPlans)
                    {
                        context.ProductionPlans.Add(production);
                    }
                    result = context.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"InsertProductionPlans出错:{ex.Message}");
                }
            }

            return result;
        }

        public BindingList<Models.ProductionPlan> FindByDateTime(string startTime,string endTime)
        {
            BindingList<Models.ProductionPlan> result = new BindingList<Models.ProductionPlan>();
            using (PingYuanDbContext context = new PingYuanDbContext())
            {
                List<Models.ProductionPlan> list = context.ProductionPlans.
                    Where(p => p.UpTime.CompareTo(startTime) >= 0
                                                && p.UpTime.CompareTo(endTime) <= 0).ToList();

                for (int i = 0; i < list.Count; i++)
                {
                    result.Add(list[i]);
                }
            }
            return result;
        }

        public int DeleteById(int id)
        {
            int result = 0;
            using (PingYuanDbContext context = new PingYuanDbContext())
            {
                try
                {
                    ProductionPlan production = context.ProductionPlans.FirstOrDefault(p => p.Id == id);
                    context.ProductionPlans.Remove(production);
                    result = context.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"InsertProductionPlans出错:{ex.Message}");
                }
            }
            return result;
        }

		public int UpdateProductionPlan(ProductionPlan role)
		{
            int result = 0;
            using (PingYuanDbContext context = new PingYuanDbContext()) {
                try
                {
                    ProductionPlan production = context.ProductionPlans.Where(p => p.Id == role.Id).FirstOrDefault();
                    production.BatchNo = role.BatchNo;
                    production.WorkpieceType = role.WorkpieceType;
                    production.PrimerColor = role.PrimerColor;
                    production.PigmentedCoatingColor = role.PigmentedCoatingColor;
                    production.VarnishColor = role.VarnishColor;
                    production.TotalNum = role.TotalNum;
                    result = context.SaveChanges();
                }
                catch (Exception ex)
                {
                    LogManager.WriteLog(LogFile.SQL, $"UpdateProductionPlan出错:{ex.Message}");
                }
            }
            return result;
		}
	}
}
