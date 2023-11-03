namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PR_PROJECT_BONUS")]
    public partial class PR_PROJECT_BONUS
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal PROJECT_ID { get; set; }

        public decimal? SALES_CONTRACT_ID { get; set; }

        public decimal? APPLY_EMPLOYEE_ID { get; set; }

        public decimal? BONUS { get; set; }

        public decimal? STATUS { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        public DateTime? CONFIRM_DATE { get; set; }

        public decimal? P_F_POOL_IN_OUT_ID { get; set; }

        public decimal? POOL_BONUS_AMOUNT { get; set; }

        public decimal? PROJECT_BONUS_AMOUNT { get; set; }

        public decimal? IS_IMPORT { get; set; }

        public decimal? RE_POOL_BONUS_AMOUNT { get; set; }

        public decimal? RE_PROJECT_BONUS_AMOUNT { get; set; }
    }
}
