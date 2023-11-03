namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PM_PARTS_TYPE")]
    public partial class PM_PARTS_TYPE
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        [Required]
        [StringLength(50)]
        public string TYPE_NAME { get; set; }

        [Required]
        [StringLength(50)]
        public string PINYIN { get; set; }

        public decimal SORT_INDEX { get; set; }

        public decimal? STATUS { get; set; }

        [StringLength(50)]
        public string TYPE_CODE { get; set; }
    }
}
