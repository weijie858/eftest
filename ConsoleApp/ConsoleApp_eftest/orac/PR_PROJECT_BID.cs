namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PR_PROJECT_BID")]
    public partial class PR_PROJECT_BID
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal PROJECT_ID { get; set; }

        public DateTime BID_DATE { get; set; }

        [Required]
        [StringLength(200)]
        public string BID_CONTENT { get; set; }

        public decimal IS_BOND { get; set; }

        public decimal COMPANY_ID { get; set; }

        public decimal EMPLOYEE_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string BID_FILE_URL { get; set; }

        public decimal STATUS { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }
    }
}
