namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PR_P_F_POOL_IN_OUT")]
    public partial class PR_P_F_POOL_IN_OUT
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal PROJECT_FUNDS_POOL_ID { get; set; }

        public decimal IN_OUT_TYPE { get; set; }

        public DateTime IN_OUT_DATE { get; set; }

        public decimal PROJECT_ID { get; set; }

        public decimal AMOUNT { get; set; }

        public decimal PROJECT_SPEND_ID { get; set; }

        public decimal STATUS { get; set; }

        [StringLength(1000)]
        public string REMARK { get; set; }

        [StringLength(30)]
        public string PROJECTNO { get; set; }

        [StringLength(250)]
        public string EXPENSE_CONTENT { get; set; }

        [StringLength(50)]
        public string EXPENSE_NO { get; set; }

        public decimal? CHANGED_PROJECT_MANAGER_ID { get; set; }

        public decimal? SALES_CONTRACT_ID { get; set; }

        public DateTime? BUSINESS_DATE { get; set; }
    }
}
