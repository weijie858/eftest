namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.SYS_EMPLOYEE_CONFIG")]
    public partial class SYS_EMPLOYEE_CONFIG
    {
        public decimal ID { get; set; }

        public decimal? REC_DELETED { get; set; }

        public decimal? REC_CREATOR { get; set; }

        public DateTime? REC_CREATE_DATE { get; set; }

        public decimal? REC_MODIFIER { get; set; }

        public DateTime? REC_MODIFY_DATE { get; set; }

        public decimal? REC_VERSION { get; set; }

        public decimal? COMPANY_ID { get; set; }

        public decimal? INNER_TRADE_FINANCE_ID { get; set; }

        [StringLength(100)]
        public string INNER_TRADE_FINANCE_NAME { get; set; }

        public decimal? PROJECT_MANAGER_ID { get; set; }

        [StringLength(100)]
        public string PROJECT_MANAGER_NAME { get; set; }
    }
}
