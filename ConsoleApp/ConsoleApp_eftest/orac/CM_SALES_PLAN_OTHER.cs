namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.CM_SALES_PLAN_OTHER")]
    public partial class CM_SALES_PLAN_OTHER
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal? SALES_PLAN_ID { get; set; }

        [StringLength(100)]
        public string PRODUCT_NAME { get; set; }

        public decimal? QUANTITY { get; set; }

        public decimal? LIMIT_PRICE { get; set; }

        public decimal? PROPOSAL_PRICE { get; set; }

        public decimal? PRICE { get; set; }

        [StringLength(300)]
        public string REMARK { get; set; }
    }
}
