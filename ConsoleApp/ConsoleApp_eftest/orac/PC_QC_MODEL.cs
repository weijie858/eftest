namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PC_QC_MODEL")]
    public partial class PC_QC_MODEL
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal STANDARD_TYPE { get; set; }

        public decimal MODEL_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string MODEL_NAME { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }
    }
}
