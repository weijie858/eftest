namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.DM_PARTS")]
    public partial class DM_PARTS
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
        public decimal PARTS_MODEL_ID { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(20)]
        public string PARTS_SN { get; set; }

        public DateTime? RECEIVE_DATE { get; set; }

        public DateTime? EXPIRE_DATE { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal STATUS { get; set; }

        [Key]
        [Column(Order = 10)]
        public decimal QUALITY { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }

        [Key]
        [Column(Order = 11)]
        public decimal DEVICE_ID { get; set; }

        public decimal? SOURCE_ID { get; set; }
    }
}
