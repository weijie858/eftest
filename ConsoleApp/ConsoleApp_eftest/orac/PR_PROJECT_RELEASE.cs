namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PR_PROJECT_RELEASE")]
    public partial class PR_PROJECT_RELEASE
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal PROJECT_ID { get; set; }

        public decimal? CONTRACT_AMOUNT { get; set; }

        public decimal? PERCENTAGE { get; set; }

        public decimal? PROJECT_ACTUAL_AMOUNT { get; set; }

        public decimal? LIMIT_AMOUNT { get; set; }

        public decimal? RELEASE_AMOUNT { get; set; }

        public decimal? ACTUAL_RELEASE_AMOUNT { get; set; }

        public decimal? RECEIVE_PAYMENT_ID { get; set; }

        public decimal? TYPE { get; set; }

        [StringLength(100)]
        public string REMARK { get; set; }

        public decimal? PROJECT_REIMBURSABLE_AMOUNT { get; set; }

        public decimal? ADJUST_AMOUNT { get; set; }
    }
}
