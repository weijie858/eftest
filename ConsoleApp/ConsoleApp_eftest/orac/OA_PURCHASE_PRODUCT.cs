namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.OA_PURCHASE_PRODUCT")]
    public partial class OA_PURCHASE_PRODUCT
    {
        public decimal ID { get; set; }

        public decimal OA_ID { get; set; }

        public decimal? PURCHASE_ID { get; set; }

        [StringLength(50)]
        public string OA_PURCHASE_ID { get; set; }

        [StringLength(200)]
        public string PRODUCT_NAME { get; set; }

        [StringLength(50)]
        public string QUANTITY { get; set; }

        [StringLength(50)]
        public string PRICE { get; set; }

        [StringLength(50)]
        public string TOTAL_AMOUNT { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }

        public decimal OPERATE_MARK { get; set; }

        public decimal IS_SYNC { get; set; }

        [StringLength(50)]
        public string OA_SYS_NAME { get; set; }
    }
}
