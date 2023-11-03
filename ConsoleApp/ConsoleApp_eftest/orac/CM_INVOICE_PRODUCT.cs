namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.CM_INVOICE_PRODUCT")]
    public partial class CM_INVOICE_PRODUCT
    {
        public decimal ID { get; set; }

        public decimal? REC_DELETED { get; set; }

        public decimal? REC_CREATOR { get; set; }

        public DateTime? REC_CREATE_DATE { get; set; }

        public decimal? REC_MODIFIER { get; set; }

        public DateTime? REC_MODIFY_DATE { get; set; }

        public decimal? REC_VERSION { get; set; }

        public decimal? SALES_CONTRACT_ID { get; set; }

        [StringLength(200)]
        public string INVOICE_PRODUCT_NAME { get; set; }

        public decimal? INVOICE_AMOUNT { get; set; }

        [StringLength(100)]
        public string REMARK { get; set; }

        public decimal? INVOICE_ID { get; set; }

        [StringLength(100)]
        public string CUSTOMER_NAME { get; set; }

        public decimal? PRICE { get; set; }

        public decimal? QUANTITY { get; set; }

        [StringLength(100)]
        public string SPECIFICATION { get; set; }

        public decimal? SIGN_PRODUCT_TYPE_ID { get; set; }

        [StringLength(100)]
        public string UNIT { get; set; }

        public decimal? PERCENT { get; set; }

        public decimal? FC_SIGN_PRODUCT_TYPE { get; set; }

        public decimal? SIGN_PRODUCT_ID { get; set; }

        [StringLength(200)]
        public string SIGN_PRODUCT_NAME { get; set; }

        public decimal? NO_RATE_AMOUNT { get; set; }

        public decimal? RATE_AMOUNT { get; set; }

        public decimal? BEFORE_NO_RATE_AMOUNT { get; set; }

        public decimal? BEFORE_RATE_AMOUNT { get; set; }
    }
}
