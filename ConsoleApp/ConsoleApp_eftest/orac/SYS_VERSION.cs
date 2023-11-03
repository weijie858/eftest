namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.SYS_VERSION")]
    public partial class SYS_VERSION
    {
        public decimal ID { get; set; }

        [Required]
        [StringLength(50)]
        public string VERSION { get; set; }

        public DateTime UPDATE_DATE { get; set; }

        [Required]
        [StringLength(500)]
        public string REMARK { get; set; }
    }
}
