namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PO_P_C_SIGN_PRODUCT")]
    public partial class PO_P_C_SIGN_PRODUCT
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal PURCHASE_CONTRACT_ID { get; set; }

        public decimal? PURCHASE_APPLY_ITEM_ID { get; set; }

        public decimal? PURCHASE_APPLY_ID { get; set; }

        public decimal? PURCHASE_ORDER_PRODUCT_ID { get; set; }

        public decimal? SALES_CONTRACT_ID { get; set; }

        public decimal? PRODUCT_ID { get; set; }

        public decimal PRODUCT_TYPE_ID { get; set; }

        [StringLength(200)]
        public string PRODUCT_NAME { get; set; }

        public decimal? MAINTENANCE_MONTH { get; set; }

        [StringLength(500)]
        public string SPECIFIC_SUPPLIER { get; set; }

        public decimal PRICE { get; set; }

        [StringLength(1000)]
        public string SPECIFICATION { get; set; }

        [StringLength(50)]
        public string UNIT { get; set; }

        public decimal QUANTITY { get; set; }

        public decimal TOTAL_AMOUNT { get; set; }

        public DateTime? BEGIN_DATE { get; set; }

        public DateTime? END_DATE { get; set; }

        public decimal? COMPLETION_RATE { get; set; }

        [StringLength(200)]
        public string PRODUCT_TYPE_NAME { get; set; }

        public decimal? IN_STORE_QUANTITY { get; set; }

        public decimal? OUT_STORE_QUANTIY { get; set; }

        public decimal? STATUS { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        public decimal? SORT_INDEX { get; set; }

        [StringLength(10)]
        public string SOURCE { get; set; }

        public decimal? RATE { get; set; }

        [StringLength(100)]
        public string MAINTENANCE_MONTH_REMARK { get; set; }

        public decimal? SALES_CONTRACT_SIGN_PRODUCT_ID { get; set; }
    }
}
