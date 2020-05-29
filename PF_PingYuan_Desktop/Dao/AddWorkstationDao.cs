using PF_PingYuan_Desktop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF_PingYuan_Desktop.Dao
{
	public class AddWorkstationDao : BaseDao
	{
		public BindingList<AddWorkstation> GetDataSource()
		{
			BindingList<AddWorkstation> result = new BindingList<AddWorkstation>();

			List<AddWorkstation> list = _context.AddWorkstations.
				OrderByDescending(a => a.TimePoint).Skip(0).Take(10).
				//Where(a => a.AreaNo == 4).
				OrderByDescending(a => a.RecordTimestamp).
				ToList();

			for (int i = 0; i < list.Count; i++)
			{
				result.Add(list[i]);
			}

			return result;
		}

		public List<AddWorkstation> GetDataSource2()
		{
			DateTime now = DateTime.Now;
			List<AddWorkstation> list = new List<AddWorkstation>();
			List<AddWorkstation> list_Area10 = _context.AddWorkstations.
					Where(a => a.AreaNo == 10).
					OrderByDescending(a => a.TimePoint).
					Skip(0).Take(5).
					ToList();

			List<AddWorkstation> list_Area1 = _context.AddWorkstations.
				Where(a => a.AreaNo == 1).
				OrderByDescending(a => a.TimePoint).
				Skip(0).Take(5).
				ToList();

			foreach (var area in list_Area10)
			{
				TimeSpan t1 = new TimeSpan(Convert.ToDateTime(area.TimePoint).Ticks);
				TimeSpan t2 = new TimeSpan(now.Ticks);
				if ((t1 - t2).Duration().TotalSeconds < 60)
				{
					list.Add(new AddWorkstation
					{
						Id = area.Id,
						AreaNo = area.AreaNo,
						RackNo = area.RackNo,
						BatchNo = area.BatchNo,
						WorkpieceNo = area.WorkpieceNo,
						WorkpieceType = area.WorkpieceType,
						PrimerColor = area.PrimerColor,
						PigmentedCoatingColor = area.PigmentedCoatingColor,
						VarnishColor = area.VarnishColor,
						TimePoint = area.TimePoint,
						RecordTimestamp = area.RecordTimestamp
					});
				}
			}

			foreach (var area in list_Area1)
			{
				TimeSpan t1 = new TimeSpan(Convert.ToDateTime(area.TimePoint).Ticks);
				TimeSpan t2 = new TimeSpan(now.Ticks);
				if ((t1 - t2).Duration().TotalSeconds < 60)
				{
					list.Add(new AddWorkstation
					{
						Id = area.Id,
						AreaNo = area.AreaNo,
						RackNo = area.RackNo,
						BatchNo = area.BatchNo,
						WorkpieceNo = area.WorkpieceNo,
						WorkpieceType = area.WorkpieceType,
						PrimerColor = area.PrimerColor,
						PigmentedCoatingColor = area.PigmentedCoatingColor,
						VarnishColor = area.VarnishColor,
						TimePoint = area.TimePoint,
						RecordTimestamp = area.RecordTimestamp
					});
				}
			}

			return list;
		}
	}
}
