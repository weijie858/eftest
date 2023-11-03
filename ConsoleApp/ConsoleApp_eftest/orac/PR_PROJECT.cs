namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PR_PROJECT")]
    public partial class PR_PROJECT
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal COMPANY_ID { get; set; }

        [Required]
        [StringLength(300)]
        public string PROJECT_NAME { get; set; }

        public decimal PROJECT_MANAGER_ID { get; set; }

        public DateTime? START_DATE { get; set; }

        public DateTime? FINISH_DATE { get; set; }

        public decimal? CUSTOMER_ID { get; set; }

        public decimal? SALES_CONTRACT_ID { get; set; }

        public decimal TOTAL_SPEND_AMOUNT { get; set; }

        public decimal PROVINCE_ID { get; set; }

        public decimal CITY_ID { get; set; }

        public decimal DISTRICT_ID { get; set; }

        public decimal STATUS { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        [StringLength(100)]
        public string PROJECT_NO { get; set; }

        [StringLength(1000)]
        public string IMPLEMENT_EMPLOYEE_IDS { get; set; }

        [StringLength(4000)]
        public string IMPLEMENT_EMPLOYEE_NAMES { get; set; }

        public DateTime? DEVICE_ORDER_DATE { get; set; }

        public DateTime? DEVICE_ARRIVAL_DATE { get; set; }

        public DateTime? EXPECT_START_DATE { get; set; }

        public DateTime? EXPECT_CHECK_DATE { get; set; }

        public DateTime? ONLINE_DATE { get; set; }

        [StringLength(500)]
        public string SALES_COMMENT { get; set; }

        public decimal? REIMBURSABLE_AMOUNT { get; set; }

        public decimal? TOTAL_AMOUNT { get; set; }

        public decimal? PROJECT_CATEGORY { get; set; }

        public DateTime? EXPECTED_ONLINE_DATE { get; set; }

        public DateTime? ACTUAL_ONLINE_DATE { get; set; }

        public DateTime? EXPECTED_ACCEPTANCE_DATE { get; set; }

        public DateTime? ACTUAL_ACCEPTANCE_DATE { get; set; }

        public decimal? ACTUAL_PROJECT_MANAGER_ID { get; set; }

        public decimal? PROJECT_AMOUNT { get; set; }

        public decimal? PROJECT_AMOUNT_PROFITS { get; set; }

        [StringLength(500)]
        public string SALES_CONTRACT_PRODUCT_IDS { get; set; }

        public decimal? PROJECT_TYPE { get; set; }

        public decimal? PROJECT_ACTUAL_AMOUNT { get; set; }

        public decimal? PROGRESS_STATUS { get; set; }

        public decimal? PROJECT_MODEL { get; set; }

        public decimal? FCPROJECTTYPE { get; set; }

        [StringLength(100)]
        public string FCPROJECTNO { get; set; }

        [StringLength(200)]
        public string FCPROJECTNAME { get; set; }

        [StringLength(300)]
        public string CUSTOMER_IDS { get; set; }

        [StringLength(10)]
        public string SOURCE { get; set; }

        public decimal? DEPARTMENT_ID { get; set; }

        public decimal? OVER_BUDGET { get; set; }

        public decimal? APPLY_EMPLOYEE_ID { get; set; }

        [StringLength(100)]
        public string APPLY_EMPLOYEE_NAME { get; set; }

        public decimal? PROJECT_PRODUCT_TYPE { get; set; }

        public decimal? TEAM_WORK { get; set; }

        public decimal? BUSINESS_ALONG { get; set; }

        public decimal? IS_NEW { get; set; }

        [StringLength(20)]
        public string WORKFLOWNUM { get; set; }

        public decimal? PROJECT_BONUS { get; set; }

        public decimal? WRITEOFF_AMOUNT { get; set; }

        [StringLength(100)]
        public string FROZENREMARK { get; set; }

        public DateTime? FROZENDATE { get; set; }

        public DateTime? EXAMINE_DATE { get; set; }
    }
}
