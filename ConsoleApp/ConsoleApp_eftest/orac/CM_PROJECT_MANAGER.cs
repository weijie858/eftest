namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.CM_PROJECT_MANAGER")]
    public partial class CM_PROJECT_MANAGER
    {
        public decimal ID { get; set; }

        public decimal? REC_DELETED { get; set; }

        public decimal? REC_CREATOR { get; set; }

        public DateTime? REC_CREATE_DATE { get; set; }

        public decimal? REC_MODIFIER { get; set; }

        public DateTime? REC_MODIFY_DATE { get; set; }

        public decimal? REC_VERSION { get; set; }

        public decimal? SALES_CONTRACT_ID { get; set; }

        public decimal? PROJECT_MANAGER_ID { get; set; }

        public decimal? PROJECT_AMOUNT_PROFITS { get; set; }

        public decimal? PROJECT_SPEND_AMOUNT { get; set; }

        public decimal? IS_NEW { get; set; }

        public decimal? COST_TYPE { get; set; }

        public decimal? IS_MAIN { get; set; }

        public decimal? PROJECT_ACTUAL_AMOUNT { get; set; }

        public decimal? YEAR { get; set; }

        public decimal? STATUS { get; set; }

        public decimal? CREATE_PROJECT { get; set; }

        public decimal? PROJECT_ID { get; set; }

        public decimal? PROJECT_BONUS { get; set; }

        [StringLength(100)]
        public string REMARK { get; set; }
    }
}
