namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PO_PURCHASE_ORDER_PARTS")]
    public partial class PO_PURCHASE_ORDER_PARTS
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

        public decimal STATUS { get; set; }

        public DateTime? PICKING_DATE { get; set; }

        public decimal? SOURCE_TYPE { get; set; }

        public decimal? REFORM_MARK { get; set; }

        public decimal? TRACK_STATUS { get; set; }

        public decimal? PARTS_TYPE_ID { get; set; }

        public decimal? PARTS_TRACK_STATUS { get; set; }

        public decimal? TRACK_STOCK_IO_STATUS { get; set; }

        public decimal? TRACK_QUANTITY { get; set; }

        public DateTime? REQUIRE_DATE { get; set; }

        public DateTime? EXPECT_DATE { get; set; }

        public DateTime? ACTUAL_DATE { get; set; }

        public decimal? CONFIRM_EMPLOYEE_ID { get; set; }

        public string PRODUCT_SNS { get; set; }

        public string PRODUCT_SUPPLIER_SNS { get; set; }

        [StringLength(300)]
        public string REMARK { get; set; }

        public decimal? PRICE { get; set; }

        public decimal? MAINTENANCE_MONTH { get; set; }

        public decimal? LINK_STOCK_BATCH_ID { get; set; }
    }
}
