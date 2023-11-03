namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.SYS_PARAMETER")]
    public partial class SYS_PARAMETER
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string PRM_CODE { get; set; }

        [StringLength(100)]
        public string PRM_VALUE { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }
    }
}
