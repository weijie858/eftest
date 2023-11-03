namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.CM_SALES_CONTRACT")]
    public partial class CM_SALES_CONTRACT
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        [StringLength(100)]
        public string CONTRACT_NO { get; set; }

        public decimal CONTRACT_TYPE { get; set; }

        public decimal SALES_ID { get; set; }

        public decimal STATUS { get; set; }

        public DateTime SIGN_DATE { get; set; }

        [StringLength(1000)]
        public string REMARK { get; set; }

        public decimal? IS_ALL_ORDERED { get; set; }

        public decimal? AMOUNT { get; set; }

        public decimal? COMPLETION_RATE { get; set; }

        [StringLength(1000)]
        public string CONTRACT_NAME { get; set; }

        public decimal? SALES_MODE { get; set; }

        public decimal? PARENT_CONTRACT_ID { get; set; }

        public decimal? BELONG_YEAR { get; set; }

        public decimal? COMPANY_ID { get; set; }

        public decimal? SOURCE_SALES_CONTRACT_ID { get; set; }

        public decimal? SUBCONTRACT_SOURCE_ID { get; set; }

        public decimal? IS_FORMAL { get; set; }

        public decimal? PROVINCE_ID { get; set; }

        public decimal? CITY_ID { get; set; }

        public decimal? DISTRICT_ID { get; set; }

        public decimal? DISCOUNT_AMOUNT { get; set; }

        public DateTime? REQUEST_SUPPLY_DATE { get; set; }

        public DateTime? REQUEST_RUN_DATE { get; set; }

        public decimal? CONVERSION_STATUS { get; set; }

        public decimal? BE_CONVERSION_STATUS { get; set; }

        [StringLength(100)]
        public string EXPENSE_POOL_IDS { get; set; }

        public decimal? BUSINESS_TYPE2 { get; set; }

        public decimal? IS_INNERCONTRACT { get; set; }

        public decimal? BELONG_PLATE { get; set; }

        public decimal? SALES_PLAN_ID { get; set; }

        [StringLength(100)]
        public string CONTRACT_NO_BPM { get; set; }

        public decimal? CONTRACT_MECHANISM { get; set; }

        public decimal? ISTENDER { get; set; }

        [StringLength(100)]
        public string WINNINGBIDARCHIVE { get; set; }

        [StringLength(100)]
        public string BUSINESS_TYPE { get; set; }

        public decimal? FINISH_STATUS { get; set; }

        [StringLength(100)]
        public string CONTRACT_NO_BPM2 { get; set; }

        public DateTime? FRAME_DATE { get; set; }

        public decimal? IS_PUBLIC_PROJECT { get; set; }

        public decimal? CREATE_COMPANY_ID { get; set; }

        [StringLength(100)]
        public string PROJECT_MANAGER_IDS { get; set; }

        public DateTime? EXPECT_FORMAL_DATE { get; set; }

        public decimal? SUBCONTRACT_AMOUNT { get; set; }

        public decimal? ISPACKAGING { get; set; }

        [StringLength(100)]
        public string REMARK2 { get; set; }

        [StringLength(20)]
        public string WORKFLOWNUM { get; set; }

        public decimal? ISCONSULTING { get; set; }

        public decimal? MAINTENANCE_END_DATE { get; set; }

        [StringLength(10)]
        public string SOURCE { get; set; }

        public decimal? DEPARTMENT_ID { get; set; }

        [StringLength(500)]
        public string SALES_HELP_IDS { get; set; }

        [StringLength(100)]
        public string SOURCE_CONTRACT_NO { get; set; }

        public decimal? TEAMWORK { get; set; }

        public decimal? WORK_AREA { get; set; }

        public decimal? BUSINESS_ALONG { get; set; }

        public decimal? PROJECT_MANAGER_ID { get; set; }

        public decimal? PROJECT_AMOUNT { get; set; }

        [StringLength(1500)]
        public string IMPLEMENT_EMPLOYEE_IDS { get; set; }

        [StringLength(1500)]
        public string IMPLEMENT_EMPLOYEE_NAMES { get; set; }

        [StringLength(100)]
        public string SECTIONNAME { get; set; }

        public decimal? PASS_CREATE_PROJECT { get; set; }

        public decimal? PROJECT_MANAGER_ID_PRE { get; set; }

        public decimal? CONTRACT_PROJECT_FINISH_STATUS { get; set; }

        public decimal? TENDER_ID { get; set; }

        [StringLength(100)]
        public string TEC_TRADE_NO { get; set; }

        public decimal? IS_FORBIDDEN { get; set; }

        public decimal? IS_POINT { get; set; }

        public decimal? IS_OLDCONTRACT { get; set; }

        public decimal? OLDCONTRACT_ID { get; set; }

        [StringLength(100)]
        public string OLDCONTRACT_NO { get; set; }

        public decimal? FROMEVALUATION_ID { get; set; }

        public decimal? MAINTENANCE_DATE { get; set; }

        [StringLength(500)]
        public string READ_EMPLOYEE_IDS { get; set; }
    }
}
