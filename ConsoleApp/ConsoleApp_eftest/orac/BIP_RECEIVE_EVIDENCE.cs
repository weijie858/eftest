namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.BIP_RECEIVE_EVIDENCE")]
    public partial class BIP_RECEIVE_EVIDENCE
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal? VERSION { get; set; }

        public decimal? MIDDLE_TYPE { get; set; }

        public decimal? DATE_TYPE { get; set; }

        public decimal? BIP_RECEIVE_ID { get; set; }

        public decimal? COMPANY_ID { get; set; }

        public decimal? SALES_CONTRACT_ID { get; set; }

        public DateTime? FINISH_DATE { get; set; }

        public DateTime? BUSINESS_DATE { get; set; }

        [StringLength(200)]
        public string CUSTOMER_CODE { get; set; }

        [StringLength(200)]
        public string CUSTOMER_NAME { get; set; }

        [StringLength(200)]
        public string CONTRACT_NO { get; set; }

        public decimal? CONTRACT_AMOUNT { get; set; }

        [StringLength(100)]
        public string BANK_ACOUNT { get; set; }

        [StringLength(100)]
        public string DSIGN_TYPE { get; set; }

        [StringLength(500)]
        public string DSIGN_REMARK { get; set; }

        public decimal? SUBJECT_CODE { get; set; }

        [StringLength(100)]
        public string SUBJECT_NAME { get; set; }

        public decimal? DEBIT_AMOUNT { get; set; }

        public decimal? CREDIT_AMOUNT { get; set; }

        [StringLength(100)]
        public string HELP_COMPUTE { get; set; }

        [StringLength(100)]
        public string HELP_COMPUTE2 { get; set; }

        [StringLength(100)]
        public string HELP_COMPUTE3 { get; set; }

        [StringLength(100)]
        public string HELP_COMPUTE4 { get; set; }

        public decimal? MONTH { get; set; }

        public decimal? SORT { get; set; }

        public decimal? STATUS { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        public decimal? FC_TYPE { get; set; }
    }
}
