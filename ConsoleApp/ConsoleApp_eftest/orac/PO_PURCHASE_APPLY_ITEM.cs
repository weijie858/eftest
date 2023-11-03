namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PO_PURCHASE_APPLY_ITEM")]
    public partial class PO_PURCHASE_APPLY_ITEM
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal PURCHASE_APPLY_ID { get; set; }

        public decimal? SALES_CONTRACT_PRODUCT_ID { get; set; }

        public DateTime? PURCHASE_DATE { get; set; }

        [StringLength(255)]
        public string SPECIFIC_SUPPLIER { get; set; }

        public decimal? CUSTOMER_ID { get; set; }

        [StringLength(255)]
        public string PRODUCT_NAME { get; set; }

        [StringLength(2000)]
        public string SPEC_PARAM { get; set; }

        public decimal? PRICE { get; set; }

        public decimal QUANTITY { get; set; }

        public decimal? PURCHASE_QUANTITY { get; set; }

        public decimal? AMOUNT { get; set; }

        [StringLength(255)]
        public string UNIT { get; set; }

        public decimal STATUS { get; set; }

        [StringLength(100)]
        public string REMARK { get; set; }

        public decimal? MAINTENANCE_MONTH { get; set; }

        [StringLength(255)]
        public string MAINTENANCE_MONTH_REMARK { get; set; }

        [StringLength(20)]
        public string DEF1 { get; set; }

        [StringLength(20)]
        public string DEF2 { get; set; }

        [StringLength(20)]
        public string DEF3 { get; set; }

        [StringLength(20)]
        public string DEF4 { get; set; }

        [StringLength(20)]
        public string DEF5 { get; set; }

        [StringLength(20)]
        public string DEF6 { get; set; }

        [StringLength(20)]
        public string DEF7 { get; set; }

        [StringLength(20)]
        public string DEF8 { get; set; }
    }
}
