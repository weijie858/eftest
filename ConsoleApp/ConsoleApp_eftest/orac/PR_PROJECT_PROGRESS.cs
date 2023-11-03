namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PR_PROJECT_PROGRESS")]
    public partial class PR_PROJECT_PROGRESS
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal PROJECT_ID { get; set; }

        public decimal PRODUCT_TYPE_ID { get; set; }

        public decimal SALES_CONTRACT_PRODUCT_ID { get; set; }

        public DateTime? PLAN_START_DATE { get; set; }

        public DateTime? START_DATE { get; set; }

        public decimal? IMPLEMENT_MANAGER_ID { get; set; }

        [StringLength(200)]
        public string IMPLEMENT_EMPLOYEE_IDS { get; set; }

        [StringLength(200)]
        public string IMPLEMENT_EMPLOYEE_NAMES { get; set; }

        [StringLength(200)]
        public string DEVELOP_EMPLOYEE_IDS { get; set; }

        [StringLength(200)]
        public string DEVELOP_EMPLOYEE_NAMES { get; set; }

        [StringLength(200)]
        public string MAINTAIN_EMPLOYE_IDS { get; set; }

        [StringLength(200)]
        public string MAINTAIN_EMPLOYE_NAMES { get; set; }

        [StringLength(300)]
        public string REMARK { get; set; }
    }
}
