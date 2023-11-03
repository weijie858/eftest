namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PO_P_O_PRODUCT_PARTS_TYPE")]
    public partial class PO_P_O_PRODUCT_PARTS_TYPE
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal? PURCHASE_ORDER_ID { get; set; }

        public decimal? PURCHASE_ORDER_PRODUCT_ID { get; set; }

        public decimal? PARTS_TYPE_ID { get; set; }

        public decimal? REQUIRE_NUM { get; set; }

        [StringLength(200)]
        public string SUGGEST_PARTS_BRAND { get; set; }

        public decimal? MODIFY_VERSION { get; set; }
    }
}
