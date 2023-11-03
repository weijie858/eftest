namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.DM_HIS_DEVICE")]
    public partial class DM_HIS_DEVICE
    {
        public decimal ID { get; set; }

        [Required]
        [StringLength(50)]
        public string DEVICE_SN { get; set; }

        [StringLength(50)]
        public string DEVICE_MODEL { get; set; }

        public DateTime? PRODUCE_DATE { get; set; }

        [StringLength(50)]
        public string SALES_CONTRACT_NO { get; set; }

        [StringLength(50)]
        public string ORDER_NO { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }
    }
}
