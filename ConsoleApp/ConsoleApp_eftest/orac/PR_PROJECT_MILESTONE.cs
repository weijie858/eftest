namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PR_PROJECT_MILESTONE")]
    public partial class PR_PROJECT_MILESTONE
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal PROJECT_ID { get; set; }

        public DateTime PLAN_DATE { get; set; }

        public DateTime? ACTUAL_DATE { get; set; }

        public decimal STATUS { get; set; }

        public decimal? RELEASE_AMOUNT { get; set; }

        public decimal ACTUAL_RELEASE_AMOUNT { get; set; }

        public decimal? PROJECT_REIMBURSABLE_AMOUNT { get; set; }

        public decimal? PASS { get; set; }

        public decimal? ADJUST_AMOUNT { get; set; }

        public decimal? TYPE { get; set; }

        public decimal? LINK_ID { get; set; }

        [StringLength(1000)]
        public string REMARK { get; set; }

        [StringLength(1000)]
        public string ATTACH_IDS { get; set; }

        [StringLength(50)]
        public string NAME { get; set; }

        public decimal? ADJUST_STATUS { get; set; }

        public decimal? OVERAGE_AMOUNT { get; set; }

        public decimal? SALES_CONTRACT_MILESTONE_ID { get; set; }
    }
}
