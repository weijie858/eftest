namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.HR_DEPT")]
    public partial class HR_DEPT
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

        [StringLength(100)]
        public string NAME { get; set; }

        [StringLength(100)]
        public string KEYWORD { get; set; }

        [StringLength(100)]
        public string SORTORDER { get; set; }

        [StringLength(100)]
        public string NO { get; set; }

        [StringLength(100)]
        public string PARENT { get; set; }

        [StringLength(10)]
        public string TYPE { get; set; }

        public decimal? THISLEADER { get; set; }

        [StringLength(100)]
        public string SUPERLEADER { get; set; }

        [StringLength(10)]
        public string DATASTATUS { get; set; }

        [StringLength(100)]
        public string REMARK { get; set; }
    }
}
