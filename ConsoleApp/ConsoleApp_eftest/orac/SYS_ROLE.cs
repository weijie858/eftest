namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.SYS_ROLE")]
    public partial class SYS_ROLE
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
        public string ROLE_NAME { get; set; }

        [StringLength(4000)]
        public string MENU_POWER_STR { get; set; }

        [StringLength(2000)]
        public string DATA_POWER_STR { get; set; }

        public decimal SORT_INDEX { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }

        [StringLength(2000)]
        public string APP_POWER_STR { get; set; }

        [StringLength(50)]
        public string CODE { get; set; }
    }
}
