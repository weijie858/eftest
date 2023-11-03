namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.CM_SP_PRODUCT_MODULE_D_ITEM")]
    public partial class CM_SP_PRODUCT_MODULE_D_ITEM
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal? SALES_PLAN_ID { get; set; }

        public decimal? SALES_PLAN_PRODUCT_ID { get; set; }

        public decimal? SP_PRODUCT_MODULE_DETAIL_ID { get; set; }

        public decimal? PRODUCT_MODULE_DETAIL_ITEM_ID { get; set; }

        [StringLength(300)]
        public string MODULE_DETAIL_ITEM_NAME { get; set; }

        public decimal? ADD_LIMIT_PRICE { get; set; }

        public decimal? ADD_SALES_PRICE { get; set; }

        public decimal? SELECT_TYPE { get; set; }

        public decimal? SORT_INDEX { get; set; }

        [StringLength(300)]
        public string REMARK { get; set; }
    }
}
