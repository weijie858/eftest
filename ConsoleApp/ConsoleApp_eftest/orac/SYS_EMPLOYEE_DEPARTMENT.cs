namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.SYS_EMPLOYEE_DEPARTMENT")]
    public partial class SYS_EMPLOYEE_DEPARTMENT
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal EMPLOYEE_ID { get; set; }

        public decimal DEPARTMENT_ID { get; set; }

        public decimal POSITION_ID { get; set; }

        public decimal? IS_MAIN { get; set; }

        public decimal? COMPANY_ID { get; set; }
    }
}
