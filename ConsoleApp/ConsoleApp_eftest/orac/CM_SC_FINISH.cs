namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.CM_SC_FINISH")]
    public partial class CM_SC_FINISH
    {
        public decimal ID { get; set; }

        public decimal? REC_DELETED { get; set; }

        public decimal? REC_CREATOR { get; set; }

        public DateTime? REC_CREATE_DATE { get; set; }

        public decimal? REC_MODIFIER { get; set; }

        public DateTime? REC_MODIFY_DATE { get; set; }

        public decimal? REC_VERSION { get; set; }

        public decimal? SALES_CONTRACT_ID { get; set; }

        [StringLength(200)]
        public string COMPANY_ID { get; set; }

        public decimal? DEPARTMENT_ID { get; set; }

        [StringLength(200)]
        public string DEPARTMENT_NAME { get; set; }

        public DateTime? APPLY_DATE { get; set; }

        public decimal? APPLY_EMPLOYEE_ID { get; set; }

        [StringLength(100)]
        public string APPLY_EMPLOYEE_NAME { get; set; }

        [StringLength(1200)]
        public string REMARK { get; set; }

        public decimal? STATUS { get; set; }
    }
}
