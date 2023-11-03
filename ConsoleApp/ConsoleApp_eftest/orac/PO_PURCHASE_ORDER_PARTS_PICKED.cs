namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PO_PURCHASE_ORDER_PARTS_PICKED")]
    public partial class PO_PURCHASE_ORDER_PARTS_PICKED
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal PURCHASE_ORDER_ID { get; set; }

        public decimal PARTS_MODEL_ID { get; set; }

        public decimal QUANTITY { get; set; }

        [Required]
        [StringLength(50)]
        public string BATCH { get; set; }

        public DateTime? PICKING_DATE { get; set; }

        public decimal? SOURCE_TYPE { get; set; }

        [StringLength(50)]
        public string PRODUCT_SN { get; set; }
    }
}
