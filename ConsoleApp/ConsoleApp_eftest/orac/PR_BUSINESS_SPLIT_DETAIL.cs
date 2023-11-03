namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PR_BUSINESS_SPLIT_DETAIL")]
    public partial class PR_BUSINESS_SPLIT_DETAIL
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        [StringLength(300)]
        public string PROJECT_NAME { get; set; }

        public decimal? PROJECT_MANAGER_ID { get; set; }

        [StringLength(100)]
        public string PROJECT_MANAGER_NAME { get; set; }

        public decimal? PROJECT_ACTUAL_AMOUNT { get; set; }

        [StringLength(100)]
        public string BONUS { get; set; }

        public decimal? TOTAL_AMOUNT { get; set; }

        public decimal? WRITE_OFF_AMOUNT { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        public decimal? BUSINESS_SPLIT_ID { get; set; }

        public decimal? PROJECT_ID { get; set; }
    }
}
