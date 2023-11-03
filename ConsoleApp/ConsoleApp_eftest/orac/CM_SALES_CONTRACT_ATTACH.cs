namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.CM_SALES_CONTRACT_ATTACH")]
    public partial class CM_SALES_CONTRACT_ATTACH
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal SOURCE_ID { get; set; }

        public decimal FILE_TYPE { get; set; }

        [Required]
        [StringLength(200)]
        public string FILENAME { get; set; }

        [Required]
        [StringLength(20)]
        public string FILE_EXT { get; set; }

        [Required]
        [StringLength(300)]
        public string FILE_URL { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }

        public decimal FILE_SIZE { get; set; }
    }
}
