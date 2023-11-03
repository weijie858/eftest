namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.CM_AGGREGATE_CONTRACT")]
    public partial class CM_AGGREGATE_CONTRACT
    {
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
        public decimal STATUS { get; set; }

        public decimal? COMPANY_ID { get; set; }

        [StringLength(1000)]
        public string REMARK { get; set; }

        [StringLength(1000)]
        public string CONTRACT_NAME { get; set; }

        [StringLength(100)]
        public string BUSINESS_TYPE { get; set; }

        public decimal? AMOUNT { get; set; }

        public decimal? PROJECT_MANAGER_ID { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal SALES_ID { get; set; }

        public decimal? TEAMWORK { get; set; }

        public decimal? PROVINCE_ID { get; set; }

        public decimal? CITY_ID { get; set; }

        public decimal? DISTRICT_ID { get; set; }

        public decimal? EXCLUDINGTAX_AMOUNT { get; set; }

        public decimal? INNER_EXCLUDINGTAX_PURCHASE { get; set; }

        public decimal? OUTER_EXCLUDINGTAX_PURCHASE { get; set; }

        public decimal? PROJECT_AMOUNT { get; set; }

        public decimal? SALE_CONTRACT_ID { get; set; }

        public decimal? BUSINESS_AMOUNT { get; set; }

        public decimal? TECH_PROJECT_MANAGER_ID { get; set; }

        public decimal? BUSINESS_PROJECT_MANAGER_ID { get; set; }

        public decimal? TYPE { get; set; }

        [StringLength(100)]
        public string PERIODTIME { get; set; }
    }
}
