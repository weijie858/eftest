namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.SYS_CUSTOM_ID")]
    public partial class SYS_CUSTOM_ID
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal TYPE { get; set; }

        [Required]
        [StringLength(50)]
        public string CUSTOM_ID_CODE { get; set; }

        [Required]
        [StringLength(50)]
        public string CUSTOM_ID_NAME { get; set; }

        public decimal CURRENT_NUM { get; set; }

        public decimal STEP { get; set; }

        public decimal TOTAL_LENGTH { get; set; }

        public decimal MAX_VALUE { get; set; }

        [StringLength(20)]
        public string PREV_STR { get; set; }

        [Required]
        [StringLength(20)]
        public string PREV_DATE_FORMAT { get; set; }
    }
}
