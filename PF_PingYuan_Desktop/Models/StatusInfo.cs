namespace PF_PingYuan_Desktop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table(name: "PY_StatusInfo")]
    public partial class StatusInfo
    {
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string EPC { get; set; }

        public int? RackNo { get; set; }

        public int? TransmitPower { get; set; }

        public decimal? PolarizationDirection { get; set; }

        public int? RSSI { get; set; }

        public int? SiteNo { get; set; }

        public int? ReadAndWriteTimes { get; set; }

        public double? Temperature { get; set; }

        [DisplayFormat(DataFormatString = "yyyy-MM-dd HH:mm:ss.fff")]
        public DateTime CurrentRecordTimestamp { get; set; }

        public int? UID { get; set; }
    }
}
