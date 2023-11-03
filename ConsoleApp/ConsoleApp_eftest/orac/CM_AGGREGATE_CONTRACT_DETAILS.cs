namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.CM_AGGREGATE_CONTRACT_DETAILS")]
    public partial class CM_AGGREGATE_CONTRACT_DETAILS
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

        public decimal? CONTRACT_ID { get; set; }

        [StringLength(100)]
        public string CONTRACT_NO { get; set; }

        [StringLength(100)]
        public string CONTRACT_NO_BPM { get; set; }

        [StringLength(200)]
        public string CONTRACT_NAME { get; set; }

        public decimal? AMOUNT { get; set; }

        [StringLength(100)]
        public string CUSTOMER_NAME { get; set; }

        public decimal? TAX { get; set; }

        public decimal? AMOUNT_NOTAX { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal AGGREGATE_ID { get; set; }
    }
}
