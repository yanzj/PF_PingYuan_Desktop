namespace PF_PingYuan_Desktop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table(name: "PY_ProgramCode")]
    public partial class ProgramCode
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string ProductCode { get; set; }

        [StringLength(50)]
        public string ProductName { get; set; }

        public int? PrimerColor { get; set; }

        public int? PaintColor { get; set; }

        public int? VarnishColor { get; set; }
    }
}
