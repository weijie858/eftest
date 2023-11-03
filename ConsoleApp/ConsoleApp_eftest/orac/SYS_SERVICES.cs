namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.SYS_SERVICES")]
    public partial class SYS_SERVICES
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
        [StringLength(50)]
        public string SERVICE_NAME { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal RUN_HOUR { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal RUN_CYCLE { get; set; }

        [StringLength(2000)]
        public string SERVICE_PARAMETER { get; set; }

        [Key]
        [Column(Order = 10)]
        public DateTime LAST_RUN_TIME { get; set; }

        [Key]
        [Column(Order = 11)]
        public decimal STATUS { get; set; }
    }
}
