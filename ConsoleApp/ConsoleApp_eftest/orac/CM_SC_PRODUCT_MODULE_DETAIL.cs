namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.CM_SC_PRODUCT_MODULE_DETAIL")]
    public partial class CM_SC_PRODUCT_MODULE_DETAIL
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal SC_PRODUCT_MODULE_ID { get; set; }

        public decimal? PRODUCT_MODULE_DETAIL_ID { get; set; }

        [StringLength(300)]
        public string MODULE_DETAIL_NAME { get; set; }

        public decimal? SELECT_TYPE { get; set; }

        public decimal? SORT_INDEX { get; set; }

        [StringLength(300)]
        public string REMARK { get; set; }

        public decimal? SALES_CONTRACT_ID { get; set; }

        public decimal? SALES_CONTRACT_PRODUCT_ID { get; set; }

        public decimal? ADD_LIMIT_PRICE { get; set; }

        public decimal? ADD_SALES_PRICE { get; set; }
    }
}
