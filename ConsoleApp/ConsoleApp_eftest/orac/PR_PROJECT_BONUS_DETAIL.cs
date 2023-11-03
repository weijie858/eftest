namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PR_PROJECT_BONUS_DETAIL")]
    public partial class PR_PROJECT_BONUS_DETAIL
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal PROJECT_ID { get; set; }

        public decimal? BONUSE_EMPLOYEE_ID { get; set; }

        public decimal? PROJECT_BONUS_ID { get; set; }

        [StringLength(100)]
        public string BONUS_EMPLOYEE_NAME { get; set; }

        public decimal? PERCENT { get; set; }

        public decimal? BONUS { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }
    }
}
