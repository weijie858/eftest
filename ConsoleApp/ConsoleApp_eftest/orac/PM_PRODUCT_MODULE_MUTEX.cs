namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PM_PRODUCT_MODULE_MUTEX")]
    public partial class PM_PRODUCT_MODULE_MUTEX
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
        [StringLength(300)]
        public string PRODUCT_MODULE_IDS { get; set; }

        public decimal MODULE_COUNT { get; set; }

        public decimal MIN_MUTEX_SELECT { get; set; }

        [StringLength(300)]
        public string REMARK { get; set; }

        public decimal? MAX_MUTEX_SELECT { get; set; }
    }
}
