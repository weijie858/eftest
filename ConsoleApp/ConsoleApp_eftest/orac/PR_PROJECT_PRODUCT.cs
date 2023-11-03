namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PR_PROJECT_PRODUCT")]
    public partial class PR_PROJECT_PRODUCT
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal PROJECT_ID { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        public decimal? SALES_CONTRACT_PRODUCT_ID { get; set; }

        public DateTime? ARRIVAL_DATE { get; set; }

        public DateTime? REMAIN_EXPECT_ARRIVAL_DATE { get; set; }

        public decimal? ARRIVAL_QUANTITY { get; set; }

        public decimal? TOTAL_AMOUNT { get; set; }

        public decimal? PERCENTAGE { get; set; }
    }
}
