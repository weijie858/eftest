namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PO_PURCHASE_CONTRACT_PAYMENT")]
    public partial class PO_PURCHASE_CONTRACT_PAYMENT
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal PURCHASE_CONTRACT_ID { get; set; }

        public DateTime? PAY_DATE { get; set; }

        public decimal AMOUNT { get; set; }

        public decimal PERCENT { get; set; }

        public decimal STATUS { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        public decimal? PLAN_CONDITION { get; set; }

        public decimal? DELAY_DAYS { get; set; }

        public DateTime? PLAN_DATE { get; set; }
    }
}
