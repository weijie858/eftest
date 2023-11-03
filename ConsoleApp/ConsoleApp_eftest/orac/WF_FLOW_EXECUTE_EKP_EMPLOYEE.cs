namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.WF_FLOW_EXECUTE_EKP_EMPLOYEE")]
    public partial class WF_FLOW_EXECUTE_EKP_EMPLOYEE
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal? FLOW_EXECUTE_ID { get; set; }

        [StringLength(100)]
        public string FLOW_EXECUTE_EKP_ID { get; set; }

        public decimal? EMPLOYEE_ID1 { get; set; }

        public decimal? EMPLOYEE_ID2 { get; set; }

        public decimal? EMPLOYEE_ID3 { get; set; }

        public decimal? EMPLOYEE_ID4 { get; set; }

        [StringLength(100)]
        public string EMPLOYEE_NAME1 { get; set; }

        [StringLength(100)]
        public string EMPLOYEE_NAME2 { get; set; }

        [StringLength(100)]
        public string EMPLOYEE_NAME3 { get; set; }

        [StringLength(100)]
        public string EMPLOYEE_NAME4 { get; set; }
    }
}
