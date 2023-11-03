namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.BASE_COMMON_SELECT_ITEM")]
    public partial class BASE_COMMON_SELECT_ITEM
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
        public decimal ITEM_TYPE { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(50)]
        public string ITEM_VALUE { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal SORT_INDEX { get; set; }

        [StringLength(20)]
        public string CODE { get; set; }
    }
}
