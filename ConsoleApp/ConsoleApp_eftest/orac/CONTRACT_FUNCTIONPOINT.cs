namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.CONTRACT_FUNCTIONPOINT")]
    public partial class CONTRACT_FUNCTIONPOINT
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
        public decimal SALE_CONTRACT_ID { get; set; }

        public decimal? US { get; set; }

        public decimal? CF { get; set; }

        public decimal? S { get; set; }

        public decimal? PDR { get; set; }

        public decimal? UE { get; set; }

        public decimal? QR { get; set; }

        public decimal? XC { get; set; }

        public decimal? AE { get; set; }

        public decimal? HM { get; set; }

        public decimal? F { get; set; }

        public decimal? P { get; set; }

        public decimal? SOFTCHANGE_ID { get; set; }

        public decimal? STATUS { get; set; }

        public decimal? FROM_TYPE { get; set; }
    }
}
