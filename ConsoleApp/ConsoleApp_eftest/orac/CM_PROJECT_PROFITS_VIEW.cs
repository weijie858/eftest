namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.CM_PROJECT_PROFITS_VIEW")]
    public partial class CM_PROJECT_PROFITS_VIEW
    {
        public decimal? PURCHASE_OUT_ACTUAL { get; set; }

        public decimal? PURCHASE_IN_ACTUAL { get; set; }

        public decimal? BUSINESS_AMOUNT { get; set; }

        public decimal? TECHNOLOGY_AMOUNT { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(36)]
        public string ID { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal CONTRACTAMOUNT { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal PURCHASE_IN { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal PURCHASE_OUT { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal OCCUPANCY_COST { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal IMPLEMENTATION_LIMIT { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal IMPLEMENTATION { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal IMPLEMENTATIONM { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal DEVELOPMENT { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal DEVELOPMENTM { get; set; }

        [Key]
        [Column(Order = 10)]
        public decimal BUSINESS_LIMIT { get; set; }

        [Key]
        [Column(Order = 11)]
        public decimal BUSINESS { get; set; }

        [Key]
        [Column(Order = 12)]
        public decimal FREE_MAINTENANCE { get; set; }

        [Key]
        [Column(Order = 13)]
        public decimal BIDDING_SERVICE_FEE { get; set; }

        [Key]
        [Column(Order = 14)]
        public decimal OTHER_COSTS { get; set; }

        [Key]
        [Column(Order = 15)]
        public decimal PROFIT_TOTAL { get; set; }

        public decimal? SALES_CONTRACT_ID { get; set; }

        public decimal? REC_DELETED { get; set; }

        public decimal? REC_CREATOR { get; set; }

        public DateTime? REC_CREATE_DATE { get; set; }

        public decimal? REC_MODIFIER { get; set; }

        public DateTime? REC_MODIFY_DATE { get; set; }

        public decimal? PROFIT_RATE { get; set; }

        public decimal? CONTRACTAMOUNT_NOTAX { get; set; }
    }
}
