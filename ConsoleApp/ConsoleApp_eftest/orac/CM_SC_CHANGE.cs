namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.CM_SC_CHANGE")]
    public partial class CM_SC_CHANGE
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal? SALES_CONTRACT_ID { get; set; }

        [StringLength(100)]
        public string CONTRACT_NO { get; set; }

        public decimal? BEFORE_SALES_CONTRACT_AMOUNT { get; set; }

        public decimal? CHANGE_SALES_CONTRACT_AMOUNT { get; set; }

        public decimal? BEFORE_PROJECT_AMOUNT_PROFITS { get; set; }

        public decimal? CHANGE_PROJECT_AMOUNT_PROFITS { get; set; }

        public decimal? TEC_PROJECT_ACTUAL_AMOUNT { get; set; }

        public decimal? TEC_BONUS { get; set; }

        public decimal? BEFORE_TEC_PERCENT { get; set; }

        public decimal? CHANGE_TEC_PERCENT { get; set; }

        public decimal? TEC_LIMIT_PECENT { get; set; }

        public decimal? BERORE_PROJECT_CONTRACT_AMOUNT { get; set; }

        public decimal? CHANGE_PROJECT_CONTRACT_AMOUNT { get; set; }

        public decimal? BEFORE_BUSINESS_PERCENT { get; set; }

        public decimal? CHANGE_BUSINESS_PERCENT { get; set; }

        public decimal? BUS_PROJECT_ACTUAL_AMOUNT { get; set; }

        public decimal? BUSINESS_BONUS { get; set; }

        public decimal? BUS_LIMIT_PECENT { get; set; }

        public decimal? STATUS { get; set; }

        [StringLength(100)]
        public string APPLY_EMPLOYEE_NAME { get; set; }

        public decimal? APPLY_EMPLOYEE_ID { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        public decimal? CONTRACT_INFO_CHNAGE { get; set; }

        public decimal? PRODUCT_CHNAGE { get; set; }

        public decimal? CUSTOMER_CHANGE { get; set; }

        public decimal? ATTACH_CHANGE { get; set; }

        public decimal? PAYMENT_CHANGE { get; set; }
    }
}
