namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.SYS_DEPARTMENT")]
    public partial class SYS_DEPARTMENT
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal PARENT_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string DEPARTMENT_NAME { get; set; }

        public decimal SORT_INDEX { get; set; }

        [Required]
        [StringLength(200)]
        public string ID_PATH { get; set; }

        public decimal? DEPARTMENT_TYPE { get; set; }

        public decimal? COMPANY_ID { get; set; }

        [StringLength(20)]
        public string DEPTID { get; set; }

        [StringLength(40)]
        public string DEPTCODE { get; set; }

        [StringLength(20)]
        public string SUPDEPTID { get; set; }

        [StringLength(40)]
        public string SUPDEPTCODE { get; set; }
    }
}
