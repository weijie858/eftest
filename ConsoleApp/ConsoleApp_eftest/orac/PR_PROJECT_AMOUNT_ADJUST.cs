namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PR_PROJECT_AMOUNT_ADJUST")]
    public partial class PR_PROJECT_AMOUNT_ADJUST
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal PROJECT_ID { get; set; }

        public decimal? SALES_CONTRACT_ID { get; set; }

        public decimal ADJUST_TYPE { get; set; }

        public decimal AMOUNT { get; set; }

        [StringLength(1000)]
        public string REMARK { get; set; }

        public decimal? APPLY_EMPLOYEE_ID { get; set; }

        [StringLength(100)]
        public string APPLY_EMPLOYEE_NAME { get; set; }

        public decimal? STATUS { get; set; }

        public decimal? BEFORE_AMOUNT { get; set; }

        public decimal? AFTER_AMOUNT { get; set; }
    }
}
