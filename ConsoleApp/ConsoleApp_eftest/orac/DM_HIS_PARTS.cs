namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.DM_HIS_PARTS")]
    public partial class DM_HIS_PARTS
    {
        public decimal ID { get; set; }

        public decimal HIS_DEVICE_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string PARTS_SN { get; set; }

        [StringLength(50)]
        public string PARTS_NAME { get; set; }

        [StringLength(50)]
        public string PARTS_MODEL { get; set; }

        [StringLength(50)]
        public string PARTS_CODE { get; set; }

        public decimal? SORT_INDEX { get; set; }
    }
}
