namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.BASE_AREA")]
    public partial class BASE_AREA
    {
        public decimal ID { get; set; }

        public decimal? PARENT_ID { get; set; }

        [StringLength(100)]
        public string AREA_NAME { get; set; }

        [StringLength(20)]
        public string ZIP_CODE { get; set; }

        [StringLength(100)]
        public string ALIAS_NAME { get; set; }

        public decimal? AREA_LEVEL { get; set; }
    }
}
