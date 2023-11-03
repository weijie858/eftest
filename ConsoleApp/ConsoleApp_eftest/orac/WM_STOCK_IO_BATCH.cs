namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.WM_STOCK_IO_BATCH")]
    public partial class WM_STOCK_IO_BATCH
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal STOCK_IO_ID { get; set; }

        public decimal STOCK_TYPE { get; set; }

        public decimal? STOCK_ID { get; set; }

        public decimal? STOCK_BATCH_ID { get; set; }

        public decimal? MODEL_ID { get; set; }

        public decimal? PRODUCT_TYPE_ID { get; set; }

        [StringLength(300)]
        public string PRODUCT_NAME { get; set; }

        [StringLength(2000)]
        public string PRODUCT_COMMENT { get; set; }

        public decimal QUANTITY { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        [StringLength(50)]
        public string BATCH { get; set; }

        public decimal? PRICE { get; set; }

        public decimal? SOURCE_ID { get; set; }

        [StringLength(100)]
        public string PRODUCT_TYPE_NAME { get; set; }

        [StringLength(50)]
        public string PRODUCT_CODE { get; set; }

        [StringLength(200)]
        public string PRODUCT_MODEL { get; set; }

        [StringLength(1000)]
        public string SPECIFICATION { get; set; }

        [StringLength(200)]
        public string SUIT_COMMENT { get; set; }

        [StringLength(200)]
        public string PRODUCT_REMARK { get; set; }
    }
}
