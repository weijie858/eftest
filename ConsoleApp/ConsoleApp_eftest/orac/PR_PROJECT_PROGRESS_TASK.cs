namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PR_PROJECT_PROGRESS_TASK")]
    public partial class PR_PROJECT_PROGRESS_TASK
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal PROJECT_ID { get; set; }

        public decimal PROJECT_PROGRESS_ID { get; set; }

        [StringLength(300)]
        public string PROGRESS_TASK { get; set; }

        public decimal? PROGRESS_STATUS { get; set; }

        public DateTime? FINISH_DATE { get; set; }

        [StringLength(500)]
        public string INCOMPLETE_COMMENT { get; set; }

        public DateTime? PLAN_FINISH_DATE { get; set; }

        [StringLength(300)]
        public string PROGRESS_COMMENT { get; set; }

        public decimal? SORT_INDEX { get; set; }
    }
}
