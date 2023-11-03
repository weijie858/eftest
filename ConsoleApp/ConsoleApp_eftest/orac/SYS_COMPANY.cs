namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.SYS_COMPANY")]
    public partial class SYS_COMPANY
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        [Required]
        [StringLength(200)]
        public string COMPANY_NAME { get; set; }

        public decimal SORT_INDEX { get; set; }

        public decimal STATUS { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        public decimal PARENT_ID { get; set; }

        [StringLength(100)]
        public string SHORT_NAME { get; set; }

        [StringLength(200)]
        public string ID_PATH { get; set; }

        [StringLength(40)]
        public string AREACODE { get; set; }
    }
}
