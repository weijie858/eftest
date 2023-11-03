namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.CM_SOFTCHANGE_EVALUATION")]
    public partial class CM_SOFTCHANGE_EVALUATION
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

        public bool? IS_INSCOPE { get; set; }

        [StringLength(1000)]
        public string REMARK { get; set; }

        public decimal? ESTIMATESVALUE { get; set; }

        public decimal? FUNCTIONPOINTS { get; set; }

        public decimal? SALES_CONTRACT_ID { get; set; }

        public decimal? STATUS { get; set; }

        public decimal? COMPANY_ID { get; set; }

        public decimal? TO_CONTRACT_ID { get; set; }
    }
}
