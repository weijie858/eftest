namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.CM_SALES_CONTRACT_SIGN_PRODUCT")]
    public partial class CM_SALES_CONTRACT_SIGN_PRODUCT
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal SALES_CONTRACT_ID { get; set; }

        public decimal PRODUCT_TYPE { get; set; }

        public decimal PRICE { get; set; }

        public decimal QUANTITY { get; set; }

        public decimal TOTAL_AMOUNT { get; set; }

        public DateTime? BEGIN_DATE { get; set; }

        public DateTime? END_DATE { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }

        [StringLength(1000)]
        public string PRODUCT_NAME { get; set; }

        public decimal? COMPLETION_RATE { get; set; }

        public decimal? MAINTENANCE_MONTH { get; set; }

        public decimal? SORT_INDEX { get; set; }

        public decimal? STATUS { get; set; }

        public decimal? SUBCONTRACT { get; set; }

        [StringLength(100)]
        public string SPECIFICATION { get; set; }

        public decimal? SIGN_PRODUCT_TYPE_ID { get; set; }

        public decimal? FC_SIGN_PRODUCT_TYPE { get; set; }

        public decimal? RATE { get; set; }
    }
}
