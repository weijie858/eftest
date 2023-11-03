namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.CM_SALES_CONTRACT_WRITEOFF")]
    public partial class CM_SALES_CONTRACT_WRITEOFF
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal SALES_CONTRACT_ID { get; set; }

        public decimal TO_SALES_CONTRACT_ID { get; set; }

        public decimal STATUS { get; set; }

        [StringLength(100)]
        public string TO_SALES_CONTRACT_NO { get; set; }

        [StringLength(100)]
        public string SALES_CONTRACT_NO { get; set; }

        [StringLength(100)]
        public string PROJECT_IDS { get; set; }

        [StringLength(100)]
        public string PURCHASE_CONTRACT_IDS { get; set; }

        [StringLength(100)]
        public string SALES_CONTRACT_INVOICE_IDS { get; set; }

        [StringLength(100)]
        public string PURCHEASE_CONTRACT_NOS { get; set; }

        [StringLength(1000)]
        public string WORK_HOURS_MAIN_IDS { get; set; }

        [StringLength(1000)]
        public string FUNCTIONPOINT_IDS { get; set; }
    }
}
