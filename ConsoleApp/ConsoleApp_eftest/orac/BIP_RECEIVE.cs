namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.BIP_RECEIVE")]
    public partial class BIP_RECEIVE
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        [StringLength(100)]
        public string VERSION { get; set; }

        public decimal? SALES_CONTRACT_ID { get; set; }

        [StringLength(100)]
        public string CONTRACT_NO { get; set; }

        public decimal? BIP_RECEIVE_ID { get; set; }

        [StringLength(300)]
        public string RECEIVE_EVIDENCE_IDS { get; set; }

        public decimal? COMPANY_ID { get; set; }

        public decimal? MIDDLE_DATE_TYPE { get; set; }

        public DateTime? FINISH_DATE { get; set; }

        public DateTime? BUSINESS_DATE { get; set; }

        public decimal? MIDDLE_TYPE { get; set; }

        public decimal? AMOUNT { get; set; }

        public decimal? NO_RATE_AMOUNT { get; set; }

        public decimal? DEBT_AMOUNT { get; set; }

        public decimal? REMAIN_AMOUNT { get; set; }

        public decimal? CUT_RATE_AMOUNT { get; set; }

        public decimal? WAIT_RATE_AMOUNT { get; set; }

        public decimal? NEED_AMOUNT { get; set; }

        public decimal? LINK_ID { get; set; }

        public decimal? MONTH { get; set; }

        public decimal? YEAR { get; set; }

        [StringLength(300)]
        public string ERROR_REMARK { get; set; }

        public decimal? STATUS { get; set; }
    }
}
