namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PO_PURCHASE_ORDER_PARTS_TRACK")]
    public partial class PO_PURCHASE_ORDER_PARTS_TRACK
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        [StringLength(50)]
        public string PARTS_TRACK_NO { get; set; }

        public DateTime? TRACK_DATE { get; set; }

        public decimal? PURCHASE_EMPLOYEE_ID { get; set; }

        [StringLength(300)]
        public string PURCHASE_ORDER_IDS { get; set; }

        [StringLength(300)]
        public string PURCHASE_ORDER_NOS { get; set; }

        public decimal? PARTS_TRACK_TYPE { get; set; }

        public decimal? SUPPLIER_ID { get; set; }

        public decimal? PARTS_MODEL_ID { get; set; }

        public decimal? QUANTITY { get; set; }

        public decimal? PARTS_TRACK_STATUS { get; set; }

        public decimal? TRACK_STOCK_IO_STATUS { get; set; }

        public DateTime? REQUIRE_DATE { get; set; }

        public DateTime? EXPECT_DATE { get; set; }

        public DateTime? ACTUAL_DATE { get; set; }

        public decimal? CONFIRM_EMPLOYEE_ID { get; set; }

        [StringLength(300)]
        public string BATCH { get; set; }

        [StringLength(4000)]
        public string PRODUCT_SUPPLIER_SNS { get; set; }

        [StringLength(300)]
        public string REMARK { get; set; }

        public string PRODUCT_SNS { get; set; }
    }
}
