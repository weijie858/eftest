namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PC_PRODUCE_TASK")]
    public partial class PC_PRODUCE_TASK
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal PURCHASE_ORDER_ID { get; set; }

        public decimal TASK_EMPLOYEE_ID { get; set; }

        [Required]
        [StringLength(200)]
        public string TASK_NAME { get; set; }

        public decimal TASK_TYPE { get; set; }

        public DateTime? START_DATE { get; set; }

        public DateTime? FINISH_DATE { get; set; }

        [StringLength(2000)]
        public string TASK_CONTENT { get; set; }

        public decimal? QC_STANDARD_ID { get; set; }

        public decimal TOTAL_QUANTITY { get; set; }

        public decimal QUALIFIED_QUANTITY { get; set; }

        public decimal QC_COUNT { get; set; }

        public decimal STATUS { get; set; }

        [StringLength(300)]
        public string REMARK { get; set; }

        public decimal EMPLOYEE_STATUS { get; set; }

        public decimal? PROJECT_ID { get; set; }

        public decimal? OTHER_TYPE { get; set; }

        public decimal? PASS_RATE { get; set; }

        public decimal? APPLY_EMPLOYEE_ID { get; set; }

        public decimal? CREATE_EMPLOYEE_ID { get; set; }
    }
}
