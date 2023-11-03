namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PO_PURCHASE_APPLY_IDCAREINFO")]
    public partial class PO_PURCHASE_APPLY_IDCAREINFO
    {
        [Key]
        [Column(Order = 0)]
        public decimal ID { get; set; }

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

        [Key]
        [Column(Order = 7)]
        public decimal MAIN_ID { get; set; }

        [StringLength(20)]
        public string DEF1 { get; set; }

        [StringLength(20)]
        public string DEF2 { get; set; }

        [StringLength(20)]
        public string DEF3 { get; set; }

        [StringLength(20)]
        public string DEF4 { get; set; }

        [StringLength(20)]
        public string DEF5 { get; set; }

        [StringLength(20)]
        public string DEF6 { get; set; }

        [StringLength(20)]
        public string DEF7 { get; set; }

        [StringLength(20)]
        public string DEF8 { get; set; }

        [StringLength(20)]
        public string DEF9 { get; set; }

        [StringLength(20)]
        public string DEF10 { get; set; }
    }
}
