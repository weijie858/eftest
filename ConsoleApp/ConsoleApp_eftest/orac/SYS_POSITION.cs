namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.SYS_POSITION")]
    public partial class SYS_POSITION
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
        public string POSITION_NAME { get; set; }

        public decimal SORT_INDEX { get; set; }

        [StringLength(300)]
        public string REMARK { get; set; }

        [StringLength(100)]
        public string POSTCODE { get; set; }

        [StringLength(40)]
        public string NCID { get; set; }
    }
}
