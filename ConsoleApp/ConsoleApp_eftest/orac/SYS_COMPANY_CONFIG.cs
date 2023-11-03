namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.SYS_COMPANY_CONFIG")]
    public partial class SYS_COMPANY_CONFIG
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal? COMPANY_ID { get; set; }

        public decimal? AUTO_COMPLETE_PROJECT { get; set; }

        public decimal? PROJECT_RELEASE_TYPE { get; set; }

        public decimal? PROJECT_AMOUNT_LIMIT_PERCENT { get; set; }

        public decimal? PROJECT_BUSINESS_PERCENT { get; set; }

        public decimal? HAND_COMPLETE_PROJECT_AMOUNT { get; set; }

        public decimal? CONTRACT_PAYMENT { get; set; }

        public decimal? PR_TECHNOLOGY_LIMIT_PERCENT { get; set; }

        public decimal? PR_BUSINESS_LIMIT_PERCENT { get; set; }

        [StringLength(100)]
        public string OUT_PRO_TECH_LIMIT_PERCENT { get; set; }

        [StringLength(100)]
        public string IN_PRO_TECH_LIMIT_PERCENT { get; set; }

        [StringLength(100)]
        public string IN_CITY_TECH_LIMIT_PERCENT { get; set; }

        public decimal? PURCHASE_INVOICE_APPROVAL { get; set; }

        public decimal? PR_BUSINESS_TEAM_WORK_PERCENT { get; set; }

        public decimal? NO_CONTRACT_INVOICE_AMOUNT { get; set; }
    }
}
