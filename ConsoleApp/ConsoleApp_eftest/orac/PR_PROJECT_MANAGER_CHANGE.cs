namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PR_PROJECT_MANAGER_CHANGE")]
    public partial class PR_PROJECT_MANAGER_CHANGE
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal PROJECT_ID { get; set; }

        public decimal PROJECT_MANAGER_ID { get; set; }

        public decimal CHANGE_PROJECT_MANAGER_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string MANAGER_NAME { get; set; }

        [Required]
        [StringLength(100)]
        public string CHANGER_MANAGER_NAME { get; set; }

        [Required]
        [StringLength(100)]
        public string APPLY_EMPLOYEE_NAME { get; set; }

        [Required]
        [StringLength(100)]
        public string PROJECT_NO { get; set; }

        public decimal STATUS { get; set; }

        public decimal? PROJECT_STATUS { get; set; }

        [StringLength(300)]
        public string REMARK { get; set; }

        public decimal? SPEND_AMOUNT { get; set; }

        public DateTime? APPLY_DATE { get; set; }

        public decimal? APPLY_EMPLOYEE_ID { get; set; }

        public decimal? REIMBURSABLE_AMOUNT { get; set; }
    }
}
