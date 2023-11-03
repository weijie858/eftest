namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PM_DEVICE_MODEL")]
    public partial class PM_DEVICE_MODEL
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        [Required]
        [StringLength(50)]
        public string MAIN_MODEL { get; set; }

        [StringLength(300)]
        public string REMARK { get; set; }

        public decimal STATUS { get; set; }

        [StringLength(50)]
        public string DEVICE_CODE { get; set; }

        [StringLength(300)]
        public string DEVICE_PICTURE_URL { get; set; }
    }
}
