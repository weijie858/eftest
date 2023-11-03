namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.SYS_EMPLOYEE")]
    public partial class SYS_EMPLOYEE
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        [Required]
        [StringLength(50)]
        public string ACCOUNT { get; set; }

        [Required]
        [StringLength(50)]
        public string PWD { get; set; }

        [Required]
        [StringLength(50)]
        public string EMPLOYEE_NAME { get; set; }

        [Required]
        [StringLength(50)]
        public string PINYIN { get; set; }

        public decimal SEX { get; set; }

        [Required]
        [StringLength(50)]
        public string MOBILE { get; set; }

        [StringLength(50)]
        public string EMAIL { get; set; }

        public decimal STATUS { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }

        [StringLength(50)]
        public string EMAIL_PWD { get; set; }

        [StringLength(28)]
        public string ICNUM { get; set; }
    }
}
