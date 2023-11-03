namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.CM_SALES_PLAN")]
    public partial class CM_SALES_PLAN
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal? SALES_CONTRACT_ID { get; set; }

        [StringLength(50)]
        public string SALES_PLAN_NO { get; set; }

        [StringLength(100)]
        public string SALES_PLAN_NAME { get; set; }

        public DateTime? CREATE_DATE { get; set; }

        public decimal? CUSTOMER_ID { get; set; }

        public decimal? PROVINCE_ID { get; set; }

        public decimal? CITY_ID { get; set; }

        public decimal? DISTRICT_ID { get; set; }

        public decimal? AMOUNT { get; set; }

        [StringLength(500)]
        public string PROJECT_COMMENT { get; set; }

        public decimal? SALES_EMPLOYEE_ID { get; set; }

        public decimal? PROJECT_EMPLOYEE_ID { get; set; }

        public decimal? PRODUCT_EMPLOYEE_ID { get; set; }

        public DateTime? CONFIRM_DATE { get; set; }

        public decimal? STATUS { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        public decimal? PLAN_TYPE { get; set; }

        public decimal? COMPANY_ID { get; set; }
    }
}
