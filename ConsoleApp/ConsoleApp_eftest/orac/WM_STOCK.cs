namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.WM_STOCK")]
    public partial class WM_STOCK
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal WAREHOUSE_ID { get; set; }

        public decimal STOCK_TYPE { get; set; }

        public decimal MODEL_ID { get; set; }

        public decimal QUANTITY { get; set; }

        public decimal? PRODUCT_TYPE_ID { get; set; }

        [StringLength(200)]
        public string PRODUCT_NAME { get; set; }

        [StringLength(200)]
        public string PRODUCT_COMMENT { get; set; }

        public decimal? POSITION_ID { get; set; }
    }
}
