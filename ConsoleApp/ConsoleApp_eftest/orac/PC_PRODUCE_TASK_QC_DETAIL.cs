namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PC_PRODUCE_TASK_QC_DETAIL")]
    public partial class PC_PRODUCE_TASK_QC_DETAIL
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal PRODUCE_TASK_PRODUCT_ID { get; set; }

        public decimal QC_STANDARD_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string STANDARD_NAME { get; set; }

        public decimal STANDARD_SORT_INDEX { get; set; }

        public decimal QC_STANDARD_ITEM_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string ITEM_NAME { get; set; }

        [StringLength(500)]
        public string QUALIFIED_STANDARD { get; set; }

        public decimal ITEM_SORT_INDEX { get; set; }

        public decimal QC_ITEM_RESULT { get; set; }
    }
}
