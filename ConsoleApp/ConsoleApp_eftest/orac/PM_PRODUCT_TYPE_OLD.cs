namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PM_PRODUCT_TYPE_OLD")]
    public partial class PM_PRODUCT_TYPE_OLD
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal PARENT_ID { get; set; }

        [Required]
        [StringLength(200)]
        public string PRODUCT_TYPE_NAME { get; set; }

        public decimal SORT_INDEX { get; set; }

        [StringLength(300)]
        public string REMARK { get; set; }

        public decimal STATUS { get; set; }

        public decimal? NEED_PURCHASE { get; set; }

        public decimal? NEED_ORDER { get; set; }

        public decimal? WITH_TRAVEL_EXPENSE { get; set; }

        public decimal? WITH_BONUS { get; set; }

        [StringLength(500)]
        public string ID_PATH { get; set; }
    }
}
