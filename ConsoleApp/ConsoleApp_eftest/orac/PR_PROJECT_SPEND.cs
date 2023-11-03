namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PR_PROJECT_SPEND")]
    public partial class PR_PROJECT_SPEND
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal PROJECT_ID { get; set; }

        public decimal EMPLOYEE_ID { get; set; }

        public DateTime SPEND_DATE { get; set; }

        public decimal AMOUNT { get; set; }

        [StringLength(2000)]
        public string SPEND_CONTENT { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        public decimal? DEPARTMENT_ID { get; set; }

        public decimal? SALES_CONTRACT_ID { get; set; }

        public decimal? STATUS { get; set; }
    }
}
