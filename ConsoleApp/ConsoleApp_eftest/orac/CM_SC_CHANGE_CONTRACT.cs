namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.CM_SC_CHANGE_CONTRACT")]
    public partial class CM_SC_CHANGE_CONTRACT
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal SALES_CONTRACT_ID { get; set; }

        [StringLength(300)]
        public string CONTRACT_NAME { get; set; }

        [StringLength(100)]
        public string CONTRACT_NO_BPM { get; set; }

        public decimal? BELONG_YEAR { get; set; }

        public DateTime? EXPECT_FORMAL_DATE { get; set; }

        public DateTime? SIGN_DATA { get; set; }

        [StringLength(100)]
        public string BUSINESS_TYPE { get; set; }

        public decimal? TEAMWORK { get; set; }

        public decimal? SALES_ID { get; set; }

        public decimal? PROVINCE_ID { get; set; }

        public decimal? CITY_ID { get; set; }

        public decimal? DISTRICT_ID { get; set; }

        public decimal? ISTENDER { get; set; }

        [StringLength(100)]
        public string WINNINGBIDARCHIVE { get; set; }

        public decimal? MAINTENANCE_END_DATE { get; set; }

        [StringLength(100)]
        public string TEC_TRADE_NO { get; set; }

        public decimal? SALES_CONTRACT_CHANGE_ID { get; set; }

        [StringLength(100)]
        public string CUSTOMER_SIGN_IDS { get; set; }

        [StringLength(100)]
        public string CUSTOMER_USE_IDS { get; set; }

        public decimal? DATA_TYPE { get; set; }

        [StringLength(1000)]
        public string ATTACH_IDS { get; set; }

        [StringLength(100)]
        public string PROVINCE_NAME { get; set; }

        [StringLength(100)]
        public string CITY_NAME { get; set; }

        [StringLength(100)]
        public string DISTRICT_NAME { get; set; }

        [StringLength(100)]
        public string SALES_NAME { get; set; }

        public decimal? PROJECT_MANAGER_ID { get; set; }

        [StringLength(100)]
        public string PROJECT_MANAGER_NAME { get; set; }
    }
}
