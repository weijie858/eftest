namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.CM_SALES_CONTRACT_SUBCONTRACT")]
    public partial class CM_SALES_CONTRACT_SUBCONTRACT
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal? BATCH { get; set; }

        [StringLength(255)]
        public string SUB_CONTRACT_NAME { get; set; }

        [StringLength(300)]
        public string REMARK { get; set; }

        public decimal SALES_CONTRACT_ID { get; set; }

        public decimal? SUB_SALES_CONTRACT_ID { get; set; }

        public decimal? SUB_COMPANY_ID { get; set; }

        [StringLength(255)]
        public string SUB_COMPANY_NAME { get; set; }

        public DateTime? SUB_SIGN_DATE { get; set; }

        public decimal? AMOUNT { get; set; }

        [StringLength(2000)]
        public string SUB_AMOUNT { get; set; }

        [StringLength(255)]
        public string SUB_REMARK { get; set; }

        [StringLength(255)]
        public string SUB_BELONG_YEAR { get; set; }

        public decimal? NOTICE_EMPLOYEE_ID { get; set; }

        [StringLength(255)]
        public string NOTICE_EMPLOYEE_NAME { get; set; }

        public decimal? SUB_SALES_ID { get; set; }

        [StringLength(255)]
        public string SUB_SALES_NAME { get; set; }

        [StringLength(255)]
        public string SUB_ATTACH_IDS { get; set; }

        [StringLength(255)]
        public string PERCENT { get; set; }

        public decimal? CONFIRM_STATUS { get; set; }

        public decimal? STATUS { get; set; }

        public decimal? PURCHASE_CONTRACT_ID { get; set; }

        public decimal? BUSINESS_ALONG { get; set; }

        public decimal? ISINNER { get; set; }

        public decimal? COMPANY_ID { get; set; }

        public decimal? SUB_CONTRACT_TYPE { get; set; }
    }
}
