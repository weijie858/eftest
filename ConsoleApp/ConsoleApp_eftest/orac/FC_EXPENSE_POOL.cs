namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.FC_EXPENSE_POOL")]
    public partial class FC_EXPENSE_POOL
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        [Required]
        [StringLength(50)]
        public string POOL_NAME { get; set; }

        public decimal TOTAL_AMOUNT { get; set; }

        public decimal REMAIN_AMOUNT { get; set; }

        public decimal STATUS { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        public decimal? COMPANY_ID { get; set; }

        public decimal? POOL_TYPE { get; set; }

        public decimal? MANAGER_ID { get; set; }

        [StringLength(50)]
        public string POOL_NO { get; set; }

        public decimal? PROJECT_TYPE { get; set; }

        public decimal? DEPARTMENT_ID { get; set; }

        public decimal? REIMBURSE_TYPE { get; set; }
    }
}
