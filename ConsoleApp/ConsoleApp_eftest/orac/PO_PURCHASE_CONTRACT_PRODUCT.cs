namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PO_PURCHASE_CONTRACT_PRODUCT")]
    public partial class PO_PURCHASE_CONTRACT_PRODUCT
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal PURCHASE_CONTRACT_ID { get; set; }

        public decimal PRODUCT_TYPE_ID { get; set; }

        [Required]
        [StringLength(200)]
        public string PRODUCT_NAME { get; set; }

        public decimal MODEL_ID { get; set; }

        public decimal QUANTITY { get; set; }

        public decimal PRICE { get; set; }

        public decimal TOTAL_AMOUNT { get; set; }

        public decimal PURCHASE_ORDER_PRODUCT_ID { get; set; }

        [StringLength(600)]
        public string REMARK { get; set; }

        public DateTime? BEGIN_DATE { get; set; }

        public DateTime? END_DATE { get; set; }

        public decimal? MAINTENANCE_MONTH { get; set; }

        [StringLength(20)]
        public string BATCH { get; set; }

        public decimal? STATUS { get; set; }

        public decimal? SALES_CONTRACT_PRODUCT_ID { get; set; }

        public decimal? STOCK_TYPE { get; set; }

        [StringLength(300)]
        public string LINK_SIGN_PRODUCT_IDS { get; set; }

        [StringLength(100)]
        public string LINK_SIGN_PRODUCT_COUNT { get; set; }

        [StringLength(1000)]
        public string SPECIFICATION { get; set; }

        [StringLength(50)]
        public string UNIT { get; set; }

        [StringLength(500)]
        public string PRODUCT_COMMENT { get; set; }

        [StringLength(500)]
        public string PRODUCT_REMARK { get; set; }

        public decimal? PURCHASE_ORDER_PARTS_ID { get; set; }

        [StringLength(50)]
        public string PRODUCT_CODE { get; set; }

        [StringLength(200)]
        public string PRODUCT_MODEL { get; set; }

        [StringLength(200)]
        public string SUIT_COMMENT { get; set; }
    }
}
