namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.CM_COST_OVER")]
    public partial class CM_COST_OVER
    {
        public decimal ID { get; set; }

        public decimal? REC_DELETED { get; set; }

        public decimal? REC_CREATOR { get; set; }

        public DateTime? REC_CREATE_DATE { get; set; }

        public decimal? REC_MODIFIER { get; set; }

        public DateTime? REC_MODIFY_DATE { get; set; }

        public decimal? REC_VERSION { get; set; }

        public decimal? SALES_CONTRACT_ID { get; set; }

        public decimal? PURCHASE_CONTRACT_ID { get; set; }

        public decimal? PROJECT_ID { get; set; }

        public decimal? OVER_AMOUNT { get; set; }

        public decimal? CUT_AMOUNT { get; set; }

        public decimal? PURCHASE_AMOUNT_NO_RATE { get; set; }

        public decimal? LINK_ID { get; set; }

        [StringLength(1000)]
        public string REMARK { get; set; }

        public decimal? PROJECT_MODEL { get; set; }

        public decimal? CUT_TYPE { get; set; }
    }
}
