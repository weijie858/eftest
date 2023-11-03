namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PR_PROJECT_MILESTONE_PRODUCT")]
    public partial class PR_PROJECT_MILESTONE_PRODUCT
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal PROJECT_ID { get; set; }

        [Required]
        [StringLength(1000)]
        public string PROJECT_MILESTONE_ID { get; set; }

        public decimal SIGN_PRODUCT_ID { get; set; }

        public decimal PROJECT_MILESTONE_STATUS { get; set; }

        public decimal SALES_CONTRACT_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string PERCENT { get; set; }

        [StringLength(100)]
        public string SIGN_PRODUCT_NAME { get; set; }

        [StringLength(100)]
        public string SIGN_PRODUCT_AMOUNT { get; set; }

        [StringLength(100)]
        public string REMARK { get; set; }
    }
}
