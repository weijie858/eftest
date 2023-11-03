namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.BASE_PAYMENT_PLAN")]
    public partial class BASE_PAYMENT_PLAN
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal PLAN_TYPE { get; set; }

        public decimal PLAN_CONDITION { get; set; }

        public decimal DELAY_DAYS { get; set; }

        public decimal? PERCENT { get; set; }

        public decimal SORT_INDEX { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }
    }
}
