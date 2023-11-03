namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PO_PURCHASE_ORDER_PRODUCT")]
    public partial class PO_PURCHASE_ORDER_PRODUCT
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal PURCHASE_ORDER_ID { get; set; }

        [Required]
        [StringLength(20)]
        public string BATCH { get; set; }

        public decimal MODEL_ID { get; set; }

        public decimal QUANTITY { get; set; }

        [StringLength(200)]
        public string DEVICE_PICTURE_URL { get; set; }

        public decimal? STATUS { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        [StringLength(20)]
        public string OPERATING_SYSTEM { get; set; }

        [StringLength(200)]
        public string SALES_CONTRACT_PRODUCT_ID { get; set; }

        public decimal? IS_REFORM { get; set; }

        public decimal? MODIFY_VERSION { get; set; }

        public decimal? STOCK_ID { get; set; }

        [StringLength(200)]
        public string DEVICE_SN { get; set; }
    }
}
