namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PR_PROJECT_COST_TRANSFER")]
    public partial class PR_PROJECT_COST_TRANSFER
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal FROM_PROJECT_ID { get; set; }

        public decimal? TO_PROJECT_ID { get; set; }

        [StringLength(50)]
        public string FROM_PROJECT_NO { get; set; }

        [StringLength(50)]
        public string TO_PROJECT_NO { get; set; }

        public decimal? FROM_PROJECT_MANAGER_ID { get; set; }

        [StringLength(50)]
        public string FROM_PROJECT_MANAGER_NAME { get; set; }

        public decimal? TO_PROJECT_MANAGER_ID { get; set; }

        [StringLength(50)]
        public string TO_PROJECT_MANAGER_NAME { get; set; }

        public decimal? TRANSFER_AMOUNT { get; set; }

        public decimal? APPLY_EMPLOYYE_ID { get; set; }

        [StringLength(50)]
        public string APPLY_EMPLOYYE_NAME { get; set; }

        public decimal? FROM_POOL_IN_OUT_ID { get; set; }

        public decimal? TO_POOL_IN_OUT_ID { get; set; }

        public decimal? STATUS { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        public decimal? REIMBURSABLE_AMOUNT { get; set; }
    }
}
