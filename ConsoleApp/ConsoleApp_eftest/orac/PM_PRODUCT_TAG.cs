namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PM_PRODUCT_TAG")]
    public partial class PM_PRODUCT_TAG
    {
        [Key]
        [Column(Order = 0)]
        public decimal ID { get; set; }

        public decimal? TAG_TYPE { get; set; }

        [StringLength(20)]
        public string TAG_CODE { get; set; }

        [StringLength(50)]
        public string TAG_NAME { get; set; }

        public decimal? SORT_INDEX { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal REC_DELETED { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal REC_CREATOR { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime REC_CREATE_DATE { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal REC_MODIFIER { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime REC_MODIFY_DATE { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal REC_VERSION { get; set; }
    }
}
