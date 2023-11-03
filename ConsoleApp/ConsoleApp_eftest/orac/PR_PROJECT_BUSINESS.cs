namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PR_PROJECT_BUSINESS")]
    public partial class PR_PROJECT_BUSINESS
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal PROJECT_ID { get; set; }

        public decimal? BUSINESS_TYPE { get; set; }

        public decimal? TAX_RATE { get; set; }

        public decimal? CONTRACT_AMOUNT { get; set; }

        public decimal? CONTRACT_AMOUNT_NO_RATE { get; set; }

        public decimal? PURCHASE_AMOUNT { get; set; }

        public decimal? PURCHASE_AMOUNT_NO_RATE { get; set; }

        [StringLength(100)]
        public string SUPPLIER_NAME { get; set; }

        public decimal? TYPE_PROFIT_PERCENTAGE { get; set; }

        public decimal? PROJECT_PERCENTAGE { get; set; }

        public decimal? PROJECT_ACTUAL_AMOUNT { get; set; }

        public decimal? PROJECT_AMOUNT { get; set; }
    }
}
