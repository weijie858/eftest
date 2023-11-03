namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.SYS_DATA_POWER")]
    public partial class SYS_DATA_POWER
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal PARENT_ID { get; set; }

        [Required]
        [StringLength(200)]
        public string TITLE { get; set; }

        [Required]
        [StringLength(10)]
        public string POWER_CODE { get; set; }

        public decimal SORT_INDEX { get; set; }

        public decimal TYPE { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }
    }
}
