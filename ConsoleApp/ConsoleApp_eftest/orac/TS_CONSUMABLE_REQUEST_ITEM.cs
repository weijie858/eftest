namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.TS_CONSUMABLE_REQUEST_ITEM")]
    public partial class TS_CONSUMABLE_REQUEST_ITEM
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal CONSUMABLE_REQUEST_ID { get; set; }

        public decimal PRODUCT_ID { get; set; }

        public decimal QUANTITY { get; set; }

        [StringLength(100)]
        public string EXPRESS_NO { get; set; }

        public DateTime? DELIVERY_DATE { get; set; }

        public DateTime? RECEIVE_DATE { get; set; }

        public decimal STATUS { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }
    }
}
