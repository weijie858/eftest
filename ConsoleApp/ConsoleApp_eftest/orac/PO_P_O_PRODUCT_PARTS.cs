namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PO_P_O_PRODUCT_PARTS")]
    public partial class PO_P_O_PRODUCT_PARTS
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal PURCHASE_ORDER_PRODUCT_ID { get; set; }

        public decimal PARTS_MODEL_ID { get; set; }

        public decimal REQUIRE_NUM { get; set; }

        public decimal? PURCHASE_ORDER_ID { get; set; }

        public decimal? QUANTITY { get; set; }

        public decimal? STATUS { get; set; }

        public decimal? SOURCE_TYPE { get; set; }

        public DateTime? RECEIVE_DATE { get; set; }

        public DateTime? SEND_DATE { get; set; }

        [StringLength(2000)]
        public string SEND_REMARK { get; set; }

        public decimal? IS_SEND_EMAIL { get; set; }

        public decimal? IS_CONTRACT { get; set; }

        public decimal? REFORM_MARK { get; set; }

        public decimal? MODIFY_VERSION { get; set; }

        public decimal? PARTS_TYPE_ID { get; set; }
    }
}
