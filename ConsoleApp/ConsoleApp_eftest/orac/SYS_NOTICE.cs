namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.SYS_NOTICE")]
    public partial class SYS_NOTICE
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal? EMPLOYEE_ID { get; set; }

        public decimal? DEPARTMENT_ID { get; set; }

        [StringLength(100)]
        public string NOTICE_TITLE { get; set; }

        [StringLength(4000)]
        public string NOTICE_CONTENT { get; set; }

        public DateTime? NOTICE_DATE { get; set; }
    }
}
