namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PC_PRODUCE_TASK_PRODUCT")]
    public partial class PC_PRODUCE_TASK_PRODUCT
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal PRODUCE_TASK_DETAIL_ID { get; set; }

        public decimal PRODUCE_TYPE { get; set; }

        [Required]
        [StringLength(50)]
        public string PRODUCT_SN { get; set; }

        public decimal? QC_EMPLOYEE_ID { get; set; }

        public DateTime? QC_DATE { get; set; }

        [StringLength(2000)]
        public string QC_RESULT { get; set; }

        public decimal STATUS { get; set; }

        public decimal? ITEM_ID { get; set; }

        public decimal QC_COUNT { get; set; }

        [StringLength(2000)]
        public string DEVICE_SN { get; set; }
    }
}
