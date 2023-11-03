namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.CM_SALES_CONTRACT_CUSTOM_SIGN")]
    public partial class CM_SALES_CONTRACT_CUSTOM_SIGN
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal SALES_CONTRACT_ID { get; set; }

        public DateTime SIGN_DATE { get; set; }

        [StringLength(500)]
        public string CUSTOMER_ID { get; set; }

        [StringLength(100)]
        public string REMARK { get; set; }

        public DateTime? HOUSTON_DATE { get; set; }

        public decimal? STATUS { get; set; }

        public decimal? QUANTITY { get; set; }
    }
}
