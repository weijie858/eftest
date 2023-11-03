namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.SYS_EMPLOYEE_ROLE")]
    public partial class SYS_EMPLOYEE_ROLE
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal EMPLOYEE_ID { get; set; }

        public decimal COMPANY_ID { get; set; }

        public decimal ROLE_ID { get; set; }

        [Required]
        [StringLength(2000)]
        public string COMPANY_ID_STR { get; set; }

        [StringLength(2000)]
        public string CUSTOM_MENU_POWER_STR { get; set; }

        [StringLength(2000)]
        public string CUSTOM_DATA_POWER_STR { get; set; }

        [StringLength(2000)]
        public string CUSTOM_APP_POWER_STR { get; set; }

        [StringLength(2000)]
        public string ROLE_ID_STR { get; set; }
    }
}
