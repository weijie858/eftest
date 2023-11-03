namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.WM_STOCK_BATCH")]
    public partial class WM_STOCK_BATCH
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal WAREHOUSE_ID { get; set; }

        public decimal STOCK_ID { get; set; }

        [Required]
        [StringLength(20)]
        public string BATCH { get; set; }

        public decimal QUANTITY { get; set; }

        public decimal? STOCK_TYPE { get; set; }

        public decimal? MODEL_ID { get; set; }

        public decimal? BATCH_SERIAL_INDEX { get; set; }

        [StringLength(50)]
        public string SALES_CONTRACT_NO { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        [StringLength(50)]
        public string PURCHASE_CONTRACT_NO { get; set; }

        public decimal? SALES_CONTRACT_PRODUCT_ID { get; set; }

        public decimal? BATCH_TYPE { get; set; }

        public decimal? PURCHASE_CONTRACT_ID { get; set; }

        [StringLength(100)]
        public string SALES_CONTRACT_ID { get; set; }

        public decimal? COMPANY_ID { get; set; }

        public decimal? SIGN_PRODUCT_ID { get; set; }

        public decimal? IN_PRICE { get; set; }

        public decimal? STOCK_IO_APPLY_ID { get; set; }
    }
}
