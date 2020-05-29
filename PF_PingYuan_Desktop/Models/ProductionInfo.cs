namespace PF_PingYuan_Desktop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table(name: "PY_ProductionInfo")]
    public partial class ProductionInfo
    {
        public int Id { get; set; }

        public int AreaNo { get; set; }

        [Display(Name = "挂具号")]
        public int RackNo { get; set; }

        [StringLength(50)]
        [Display(Name = "批次编号")]
        public string BatchNo { get; set; }

        [Display(Name = "工件编号")]
        [StringLength(50)]
        public string WorkpieceNo { get; set; }

        [StringLength(50)]
        [Display(Name = "工件类型")]
        public string WorkpieceType { get; set; }

        [StringLength(50)]
        [Display(Name = "底漆颜色")]
        public string PrimerColor { get; set; }

        [StringLength(50)]
        [Display(Name = "底漆厂商")]
        public string PrimerFirm { get; set; }

        [StringLength(50)]
        [Display(Name = "底漆工艺")]
        public string PrimerCraft { get; set; }

        [StringLength(50)]
        [Display(Name = "色漆颜色")]
        public string PigmentedCoatingColor { get; set; }

        [StringLength(50)]
        [Display(Name = "色漆厂商")]
        public string PigmentedCoatingFirm { get; set; }

        [StringLength(50)]
        [Display(Name = "色漆工艺")]
        public string PigmentedCoatingCraft { get; set; }

        [StringLength(50)]
        [Display(Name = "清漆颜色")]
        public string VarnishColor { get; set; }

        [StringLength(50)]
        [Display(Name = "请求厂商")]
        public string VarnishFirm { get; set; }

        [StringLength(50)]
        [Display(Name = "清漆工艺")]
        public string VarnishCraft { get; set; }

        [Display(Name = "有效性")]
        public int? Validity { get; set; }


        [Display(Name = "时间戳")]
        [DisplayFormat(DataFormatString = "yyyy-MM-dd HH:mm:ss.fff")]
        public DateTime RecordTimestamp { get; set; }

        [Display(Name = "UID")]
        public int? UID { get; set; }
    }
}
