namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PM_SOFTWARE_MODULE")]
    public partial class PM_SOFTWARE_MODULE
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal SOFTWARE_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string MODULE_NAME { get; set; }

        public decimal PRICE { get; set; }

        public decimal IS_OPTIONAL { get; set; }

        public decimal SORT_INDEX { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        public decimal? LIMIT_PRICE { get; set; }
    }
}
