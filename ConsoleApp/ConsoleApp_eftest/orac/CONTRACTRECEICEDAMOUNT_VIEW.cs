namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.CONTRACTRECEICEDAMOUNT_VIEW")]
    public partial class CONTRACTRECEICEDAMOUNT_VIEW
    {
        [StringLength(4000)]
        public string CUSTOMER_NAME { get; set; }

        [Key]
        [Column(Order = 0)]
        public decimal ID { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal REC_DELETED { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal REC_CREATOR { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime REC_CREATE_DATE { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal REC_MODIFIER { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime REC_MODIFY_DATE { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal REC_VERSION { get; set; }

        [StringLength(100)]
        public string CONTRACT_NO { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal CONTRACT_TYPE { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal SALES_ID { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal STATUS { get; set; }

        [Key]
        [Column(Order = 10)]
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

        public decimal? RECEIVE_AMOUNT { get; set; }
    }
}
