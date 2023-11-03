namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.SYS_SERIAL_NUMBER")]
    public partial class SYS_SERIAL_NUMBER
    {
        [Key]
        [Column(Order = 0)]
        public decimal AREACODE { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal YEAR { get; set; }

        public decimal? CURRENT_NUM { get; set; }

        public decimal? BEGIN_NUM { get; set; }

        public decimal? END_NUM { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string TYPE { get; set; }
    }
}
