namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PR_BUSINESS_SPLIT")]
    public partial class PR_BUSINESS_SPLIT
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal COMPANY_ID { get; set; }

        public decimal? SALES_CONTRACT_ID { get; set; }

        [StringLength(100)]
        public string PROJECT_IDS { get; set; }

        [StringLength(100)]
        public string PROJECT_AMOUNT_PROFITS { get; set; }

        public decimal? APPLY_EMPLOYEE_ID { get; set; }

        [StringLength(100)]
        public string APPLY_EMPLOYEE_NAME { get; set; }

        public DateTime? APPLY_DATE { get; set; }

        public decimal? STATUS { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        public decimal? PROJECT_ACTUAL_AMOUNT { get; set; }

        public decimal? WRITE_OFF_AMOUNT { get; set; }

        public decimal? BONUS { get; set; }

        public decimal? BUSINESS_ALONG { get; set; }

        public decimal? TYPE { get; set; }
    }
}
