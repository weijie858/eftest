namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PR_PROJECT_DEPLOY_INFO")]
    public partial class PR_PROJECT_DEPLOY_INFO
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal PROJECT_ID { get; set; }

        public decimal? PROJECT_DEPLOY_TYPE_ID { get; set; }

        [StringLength(500)]
        public string DEPLOY_TITLE { get; set; }

        [StringLength(4000)]
        public string DEPLOY_CONTENT { get; set; }

        public decimal? SORT_INDEX { get; set; }
    }
}
