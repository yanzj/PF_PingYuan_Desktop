namespace PF_PingYuan_Desktop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table(name: "PY_User")]
    public partial class User
    {
        [Key]
        [StringLength(50)]
        [Display(Name = "工号")]
        public string JobNo { get; set; }

        [StringLength(50)]
        [Display(Name = "用户名")]
        public string UserName { get; set; }

        [StringLength(50)]
        [Display(Name = "密码")]
        public string Password { get; set; }

        [StringLength(50)]
        [Display(Name = "所属部门")]
        public string Department { get; set; }

        [StringLength(50)]
        [Display(Name = "操作权限")]
        public string OperationAuthority { get; set; }

        [StringLength(50)]
        [Display(Name = "权限解释")]
        public string Explanation { get; set; }

        [Display(Name = "有效性")]
        public int? Effectiveness { get; set; }

        [StringLength(50)]
        [Display(Name = "备注信息")]
        public string RemarkInfo { get; set; }

        [Display(Name = "当前记录的时间戳")]
        [DisplayFormat(DataFormatString = "yyyy-MM-dd HH:mm:ss.fff")]
        public DateTime RecordTimestamp { get; set; }

        [Display(Name = "当前记录UID")]
        public int? UID { get; set; }
    }
}
