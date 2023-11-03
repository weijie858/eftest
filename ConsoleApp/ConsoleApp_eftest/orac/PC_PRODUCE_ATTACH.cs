namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PC_PRODUCE_ATTACH")]
    public partial class PC_PRODUCE_ATTACH
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal PRODUCE_SOURCE_ID { get; set; }

        public decimal ATTACH_TYPE { get; set; }

        [Required]
        [StringLength(200)]
        public string FILENAME { get; set; }

        [Required]
        [StringLength(50)]
        public string FILE_EXT { get; set; }

        [Required]
        [StringLength(500)]
        public string FILE_URL { get; set; }

        public decimal FILE_SIZE { get; set; }

        public decimal? UPLOAD_EMPLOYEE_ID { get; set; }
    }
}
