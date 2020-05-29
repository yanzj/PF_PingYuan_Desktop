using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF_PingYuan_Desktop.Models
{
    [Table(name: "PY_AddWorkstation")]
	public partial class AddWorkstation
	{
        public int Id { get; set; }

        [Display(Name = "区域编号")]
        public int? AreaNo { get; set; }

        [Display(Name = "挂具号")]
        public int? RackNo { get; set; }

        [Display(Name = "批次号")]
        [StringLength(50)]
        public string BatchNo { get; set; }

        [Display(Name = "工件编号")]
        [StringLength(50)]
        public string WorkpieceNo { get; set; }

        [Display(Name = "程序号")]
        [StringLength(50)]
        public string WorkpieceType { get; set; }

        [Display(Name = "底漆颜色")]
        [StringLength(50)]
        public string PrimerColor { get; set; }

        [Display(Name = "色漆颜色")]
        [StringLength(50)]
        public string PigmentedCoatingColor { get; set; }

        [Display(Name = "清漆颜色")]
        [StringLength(50)]
        public string VarnishColor { get; set; }

        [StringLength(50)]
        public string TimePoint { get; set; }

        public DateTime? RecordTimestamp { get; set; }
    }
}
