namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.FC_RECEIVE_PAYMENT")]
    public partial class FC_RECEIVE_PAYMENT
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal? COMPANY_ID { get; set; }

        public DateTime RECEIVE_DATE { get; set; }

        public decimal RECEIVE_AMOUNT { get; set; }

        public decimal? CUSTOMER_ID { get; set; }

        public decimal? SALES_EMPLOYEE_ID { get; set; }

        public decimal? SALES_CONTRACT_ID { get; set; }

        public decimal RECORD_EMPLOYEE_ID { get; set; }

        public DateTime RECORD_DATE { get; set; }

        public decimal STATUS { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        public decimal? CONDITION { get; set; }

        [StringLength(100)]
        public string WATERNUM { get; set; }

        public decimal? DEPTID { get; set; }

        [StringLength(20)]
        public string UNIT { get; set; }

        [StringLength(255)]
        public string TITLE { get; set; }

        [StringLength(36)]
        public string PID { get; set; }

        public DateTime? FINISH_DATE { get; set; }
    }
}
