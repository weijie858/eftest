namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.CM_SALES_CONTRACT_MILESTONE")]
    public partial class CM_SALES_CONTRACT_MILESTONE
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

        public decimal? PROJECT_ID { get; set; }

        public decimal? CONTRACT_PROJECT_MANAGER_ID { get; set; }

        [StringLength(100)]
        public string SECTION_NAME { get; set; }

        public decimal? COST_TYPE { get; set; }

        public decimal? COST_RANGE { get; set; }

        [StringLength(100)]
        public string PERCENT { get; set; }

        [StringLength(100)]
        public string ADD_PERCENT { get; set; }

        public decimal? AMOUNT { get; set; }

        [StringLength(100)]
        public string ADD_AMOUNT { get; set; }

        [StringLength(300)]
        public string ATTACH_IDS { get; set; }

        [StringLength(100)]
        public string SIGN_PRODUCT_IDS { get; set; }

        [StringLength(100)]
        public string PAYMENT_IDS { get; set; }

        public decimal? STATUS { get; set; }

        public DateTime? PLAN_DATE { get; set; }

        public decimal? IS_MAIN { get; set; }

        public decimal? MUST { get; set; }

        public decimal? SORT { get; set; }

        public DateTime? CONFIRM_DATE { get; set; }

        [StringLength(300)]
        public string LINK_ID { get; set; }

        [StringLength(100)]
        public string PLAN_PAYMENT_IDS { get; set; }

        [StringLength(100)]
        public string PLAN_SIGN_PRODUCT_IDS { get; set; }

        public DateTime? FINISH_DATE { get; set; }

        public decimal? SYS_MILESTONE_ID { get; set; }

        public decimal? PREDICT_WORKHOURS { get; set; }
    }
}
