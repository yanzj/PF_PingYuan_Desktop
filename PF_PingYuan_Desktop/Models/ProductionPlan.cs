namespace PF_PingYuan_Desktop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table(name: "PY_ProductionPlan")]
    public partial class ProductionPlan
    {
        //[Display(Name = "批次编号")]
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string BatchNo { get; set; }

        //[Display(Name = "工件编号")]
        [StringLength(50)]
        public string WorkpieceNo { get; set; }

        //[Display(Name = "工件类型")]
        [StringLength(50)]
        public string WorkpieceType { get; set; }

        //[Display(Name = "底漆颜色")]
        [StringLength(50)]
        public string PrimerColor { get; set; }

        //[Display(Name = "底漆厂商")]
        [StringLength(50)]
        public string PrimerFirm { get; set; }

        //[Display(Name = "底漆工艺")]
        [StringLength(50)]
        public string PrimerCraft { get; set; }

        //[Display(Name = "色漆颜色")]
        [StringLength(50)]
        public string PigmentedCoatingColor { get; set; }

        //[Display(Name = "色漆厂商")]
        [StringLength(50)]
        public string PigmentedCoatingFirm { get; set; }

        //[Display(Name = "色漆工艺")]
        [StringLength(50)]
        public string PigmentedCoatingCraft { get; set; }

        //[Display(Name = "清漆颜色")]
        [StringLength(50)]
        public string VarnishColor { get; set; }

        //[Display(Name = "清漆厂商")]
        [StringLength(50)]
        public string VarnishFirm { get; set; }

        //[Display(Name = "清漆工艺")]
        [StringLength(50)]
        public string VarnishCraft { get; set; }

        //[Display(Name = "有效性")]
        public int? Validity { get; set; }

        //[Display(Name = "上件时间")]
        [StringLength(50)]
        public string UpTime { get; set; }

        //[Display(Name = "时间戳")]
        [DisplayFormat(DataFormatString = "yyyy-MM-dd HH:mm:ss.fff")]
        public DateTime RecordTimestamp { get; set; }

        //[Display(Name = "UID")]
        public int? UID { get; set; }

        public int? TotalNum { get; set; }
    }
}
