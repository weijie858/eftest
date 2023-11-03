namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PM_PARTS_MODEL")]
    public partial class PM_PARTS_MODEL
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        [Required]
        [StringLength(100)]
        public string PARTS_NAME { get; set; }

        [Required]
        [StringLength(20)]
        public string PARTS_CODE { get; set; }

        [StringLength(50)]
        public string FACTORY_MODEL { get; set; }

        public decimal SUPPLIER_ID { get; set; }

        [StringLength(20)]
        public string UNIT { get; set; }

        public decimal? UNIT_PRICE { get; set; }

        [StringLength(2000)]
        public string SPECIFICATION { get; set; }

        public decimal STATUS { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }

        public decimal HAS_COMPONENT { get; set; }

        public decimal? PARENT_ID { get; set; }

        public decimal? DEFAULT_SOURCE_TYPE { get; set; }

        [StringLength(200)]
        public string ATTRIBUTE { get; set; }

        public decimal? MAINTENANCE_PERIOD { get; set; }

        [StringLength(50)]
        public string FIRMWARE_VER { get; set; }

        public DateTime? LAST_TEST_DATE { get; set; }

        [StringLength(300)]
        public string PICTURE_URL { get; set; }

        [StringLength(200)]
        public string PARTS_TYPE_IDS { get; set; }

        [StringLength(200)]
        public string BRAND { get; set; }

        public decimal? DELIVERY_DAYS { get; set; }

        public decimal? PAYMENT_DAYS { get; set; }

        public decimal? IS_BARCODE { get; set; }
    }
}
