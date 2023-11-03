namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.DM_DEVICE")]
    public partial class DM_DEVICE
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal PURCHASE_ORDER_PRODUCT_ID { get; set; }

        public decimal CUSTOMER_ID { get; set; }

        public decimal DEVICE_MODEL_ID { get; set; }

        [Required]
        [StringLength(20)]
        public string DEVICE_SN { get; set; }

        public DateTime? PRODUCE_DATE { get; set; }

        public DateTime? ARRIVAL_DATE { get; set; }

        public DateTime? EXPIRE_DATE { get; set; }

        public decimal STATUS { get; set; }

        public decimal QUALITY { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }

        public decimal? SALES_CONTRACT_ID { get; set; }

        public decimal? SALES_CONTRACT_PRODUCT_ID { get; set; }
    }
}
