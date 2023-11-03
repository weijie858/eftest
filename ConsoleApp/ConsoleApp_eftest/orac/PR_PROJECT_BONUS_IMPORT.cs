namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PR_PROJECT_BONUS_IMPORT")]
    public partial class PR_PROJECT_BONUS_IMPORT
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        [Required]
        [StringLength(500)]
        public string PROJECT_BONUS_IDS { get; set; }

        public decimal COMPANY_ID { get; set; }

        public decimal POOL_BONUS_AMOUNT { get; set; }

        public decimal PROJECT_BONUS_AMOUNT { get; set; }

        [StringLength(100)]
        public string RE_EMPLOYEE_NAME { get; set; }

        public decimal? RE_EMPLOYEE_ID { get; set; }

        public decimal? STATUS { get; set; }

        public decimal? IS_CHECK { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }
    }
}
