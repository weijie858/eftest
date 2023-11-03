namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.CM_SALES_CONTRACT_PAYMENT")]
    public partial class CM_SALES_CONTRACT_PAYMENT
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal SALES_CONTRACT_ID { get; set; }

        public DateTime? RECEIVE_PLAN_DATE { get; set; }

        public decimal AMOUNT { get; set; }

        public decimal PERCENT { get; set; }

        public DateTime? RECEIVE_DATE { get; set; }

        public decimal STATUS { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        public decimal? PLAN_CONDITION { get; set; }

        public decimal? DELAY_DAYS { get; set; }

        public decimal? IS_INVOICED { get; set; }

        public decimal? IS_WEEKDAY { get; set; }

        public DateTime? RECENTLY_DATE { get; set; }

        public decimal? COUNT { get; set; }

        public decimal? PAYMENT_ID { get; set; }

        public DateTime? CONFIRMDATE { get; set; }

        public decimal? FINISH_PERCENT { get; set; }

        public decimal? ISNEW { get; set; }

        public decimal? SORT { get; set; }
    }
}
