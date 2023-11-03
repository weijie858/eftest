namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.BASE_BARCODE_PRINT_INSTRUCTION")]
    public partial class BASE_BARCODE_PRINT_INSTRUCTION
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal BARCODE_TYPE { get; set; }

        [Required]
        [StringLength(50)]
        public string BARCODE_SIZE { get; set; }

        [Required]
        [StringLength(1000)]
        public string INSTRUCTION_TEMPLATE { get; set; }

        public decimal STATUS { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }
    }
}
