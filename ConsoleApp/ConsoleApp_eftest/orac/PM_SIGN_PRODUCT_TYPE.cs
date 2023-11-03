namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PM_SIGN_PRODUCT_TYPE")]
    public partial class PM_SIGN_PRODUCT_TYPE
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal? COMPANY_ID { get; set; }

        [StringLength(100)]
        public string PRODUCT_TYPE_NAME { get; set; }

        public decimal? SORT_INDEX { get; set; }

        public decimal? PARENT_ID { get; set; }

        public decimal? DEEP { get; set; }

        [StringLength(1000)]
        public string DEEP_IDS { get; set; }
    }
}
