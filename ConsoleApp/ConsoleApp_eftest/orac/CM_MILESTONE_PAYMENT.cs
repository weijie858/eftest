namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.CM_MILESTONE_PAYMENT")]
    public partial class CM_MILESTONE_PAYMENT
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        [Required]
        [StringLength(1000)]
        public string CONTRACT_MILESTONE_ID { get; set; }

        public decimal SALES_CONTRACT_ID { get; set; }

        [StringLength(100)]
        public string REMARK { get; set; }

        public decimal? CONFIRM_TYPE { get; set; }

        public decimal? SALES_CONTRACT_PAYMENT_ID { get; set; }
    }
}
