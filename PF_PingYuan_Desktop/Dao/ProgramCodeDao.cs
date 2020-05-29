using PF_PingYuan_Desktop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF_PingYuan_Desktop.Dao
{
	public class ProgramCodeDao : BaseDao
	{
        public BindingList<Models.ProgramCode> GetDataSource()
        {
            BindingList<Models.ProgramCode> result = new BindingList<Models.ProgramCode>();
            List<Models.ProgramCode> list = _context.ProgramCodes.OrderBy(p => p.ProductCode.Length).ThenBy(p => p.ProductCode).ToList();

            for (int i = 0; i < list.Count; i++)
            {
                result.Add(list[i]);
            }

            return result;
        }

        public int InsertProgramCode(ProgramCode programCode)
        {
            int ret = 0;
            try
            {
                using (PingYuanDbContext context = new PingYuanDbContext())
                {
                    context.ProgramCodes.Add(programCode);
                    ret = context.SaveChanges();
                }
            }
            catch(Exception ex)
            {

            }
            return ret;
        }

        public int DeleteProgramCodeById(ProgramCode programCode)
        {
            int result = 0;
            try
            {
                using (PingYuanDbContext context = new PingYuanDbContext())
                {
                    ProgramCode pro = context.ProgramCodes.FirstOrDefault(p => p.Id == programCode.Id);
                    context.ProgramCodes.Remove(pro);
                    result = context.SaveChanges();
                }
            }
            catch(Exception ex)
            {

            }
            return result;
        }
    }
}
