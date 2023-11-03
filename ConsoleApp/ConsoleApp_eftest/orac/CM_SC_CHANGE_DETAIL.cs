namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.CM_SC_CHANGE_DETAIL")]
    public partial class CM_SC_CHANGE_DETAIL
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal SALES_CONTRACT_ID { get; set; }

        public decimal PRICE { get; set; }

        public decimal QUANTITY { get; set; }

        public decimal TOTAL_AMOUNT { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }

        [StringLength(1000)]
        public string PRODUCT_NAME { get; set; }

        public decimal? MAINTENANCE_MONTH { get; set; }

        public decimal? SORT_INDEX { get; set; }

        [StringLength(100)]
        public string SPECIFICATION { get; set; }

        public decimal? SIGN_PRODUCT_TYPE_ID { get; set; }

        public decimal? FC_SIGN_PRODUCT_TYPE { get; set; }

        public decimal? RATE { get; set; }

        public decimal? PROJECT_ID { get; set; }

        public decimal? PROJECT_ACTUAL_AMOUNT { get; set; }

        [StringLength(100)]
        public string PROJECT_NO { get; set; }

        public decimal? CUT_AMOUNT { get; set; }

        public decimal? DATA_TYPE { get; set; }

        public decimal? SALES_CONTRACT_CHANGE_ID { get; set; }

        public decimal? PROJECT_MODEL { get; set; }

        [StringLength(100)]
        public string SIGN_PRODUCT_ID { get; set; }
    }
}
