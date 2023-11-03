namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.CM_PROJECT_PROFITS")]
    public partial class CM_PROJECT_PROFITS
    {
        [StringLength(36)]
        public string ID { get; set; }

        public decimal CONTRACTAMOUNT { get; set; }

        public decimal PURCHASE_IN { get; set; }

        public decimal PURCHASE_OUT { get; set; }

        public decimal OCCUPANCY_COST { get; set; }

        public decimal IMPLEMENTATION_LIMIT { get; set; }

        public decimal IMPLEMENTATION { get; set; }

        public decimal IMPLEMENTATIONM { get; set; }

        public decimal DEVELOPMENT { get; set; }

        public decimal DEVELOPMENTM { get; set; }

        public decimal BUSINESS_LIMIT { get; set; }

        public decimal BUSINESS { get; set; }

        public decimal FREE_MAINTENANCE { get; set; }

        public decimal BIDDING_SERVICE_FEE { get; set; }

        public decimal OTHER_COSTS { get; set; }

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
