namespace PF_PingYuan_Desktop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table(name: "PY_RackSeq")]
    public partial class RackSeq
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string AreaNo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string PendantSequence { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] CurrentRecordTimestamp { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CurrentRecordUID { get; set; }
    }
}
