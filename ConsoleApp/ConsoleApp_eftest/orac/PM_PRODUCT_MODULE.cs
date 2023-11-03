namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PM_PRODUCT_MODULE")]
    public partial class PM_PRODUCT_MODULE
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal PRODUCT_ID { get; set; }

        [Required]
        [StringLength(200)]
        public string MODULE_NAME { get; set; }

        public decimal? ADD_LIMIT_PRICE { get; set; }

        public decimal? ADD_SALES_PRICE { get; set; }

        public decimal SELECT_TYPE { get; set; }

        public decimal SORT_INDEX { get; set; }

        [StringLength(300)]
        public string REMARK { get; set; }

        public decimal? MIN_SUB_SELECT { get; set; }

        public decimal? MAX_SUB_SELECT { get; set; }

        [StringLength(200)]
        public string LINK_PARTS_TYPE_IDS { get; set; }
    }
}
