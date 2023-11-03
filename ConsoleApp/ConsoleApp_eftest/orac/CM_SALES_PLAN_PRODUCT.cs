namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.CM_SALES_PLAN_PRODUCT")]
    public partial class CM_SALES_PLAN_PRODUCT
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal SALES_PLAN_ID { get; set; }

        public decimal PRODUCT_TYPE_ID { get; set; }

        [Required]
        [StringLength(200)]
        public string PRODUCT_TYPE_NAME { get; set; }

        public decimal PRODUCT_ID { get; set; }

        [Required]
        [StringLength(300)]
        public string PRODUCT_NAME { get; set; }

        public decimal BASE_LIMIT_PRICE { get; set; }

        public decimal BASE_SALES_PRICE { get; set; }

        [StringLength(50)]
        public string UNIT { get; set; }

        [StringLength(300)]
        public string PRODUCT_REMARK { get; set; }

        [StringLength(300)]
        public string PRODUCT_COMMENT { get; set; }

        public decimal TOTAL_LIMIT_PRICE { get; set; }

        public decimal TOTAL_SALES_PRICE { get; set; }

        public decimal QUANTITY { get; set; }

        [StringLength(300)]
        public string PRODUCT_PICTURE_URL { get; set; }

        [StringLength(300)]
        public string REMARK { get; set; }

        public decimal TOTAL_PRICE { get; set; }

        public decimal AMOUNT { get; set; }

        public decimal? CUSTOMER_ID { get; set; }

        [StringLength(300)]
        public string SPECIFICATION { get; set; }

        public decimal? MAINTENANCE_MONTH { get; set; }

        [StringLength(50)]
        public string PRODUCT_CODE { get; set; }

        [StringLength(200)]
        public string PRODUCT_MODEL { get; set; }

        [StringLength(200)]
        public string SUIT_COMMENT { get; set; }
    }
}
