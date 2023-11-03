namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PM_COMPONENT_MODEL")]
    public partial class PM_COMPONENT_MODEL
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal PARTS_TYPE_ID { get; set; }

        public decimal COMPONENT_TYPE { get; set; }

        public decimal PARTS_MODEL_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string COMPONENT_NAME { get; set; }

        [Required]
        [StringLength(50)]
        public string COMPONENT_CODE { get; set; }

        [Required]
        [StringLength(50)]
        public string FACTORY_MODEL { get; set; }

        public decimal SUPPLIER_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string UNIT { get; set; }

        public decimal UNIT_PRICE { get; set; }

        [StringLength(2000)]
        public string SPECIFICATION { get; set; }

        public decimal MAINTENANCE_PERIOD { get; set; }

        public decimal IS_STICK_BARCODE { get; set; }

        public decimal? STATUS { get; set; }

        [StringLength(300)]
        public string SUIT_PARTS_COMMENT { get; set; }

        [StringLength(300)]
        public string REMARK { get; set; }

        [StringLength(300)]
        public string PICTURE_URL { get; set; }
    }
}
