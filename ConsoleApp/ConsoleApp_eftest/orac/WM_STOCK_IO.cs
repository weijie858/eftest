namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.WM_STOCK_IO")]
    public partial class WM_STOCK_IO
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal? IO_TYPE { get; set; }

        public decimal? WAREHOUSE_ID { get; set; }

        public decimal STATUS { get; set; }

        public decimal? CHECK_EMPLOYEE_ID { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        public decimal? REQUEST_EMPLOYEE_ID { get; set; }

        public decimal? SOURCE_TYPE { get; set; }

        public decimal? SOURCE_ID { get; set; }

        [StringLength(1000)]
        public string SOURCE_COMMENT { get; set; }

        public DateTime? REQUEST_DATE { get; set; }

        public DateTime? CHECK_DATE { get; set; }

        [StringLength(20)]
        public string STOCK_IO_NO { get; set; }

        [StringLength(1000)]
        public string CHECK_COMMENT { get; set; }

        [StringLength(200)]
        public string EXPRESS_NO { get; set; }

        public decimal? EXPRESS_TYPE { get; set; }

        [StringLength(50)]
        public string LINK_STOCK_IO_NO { get; set; }

        public decimal? TARGET_TYPE { get; set; }

        public decimal? TARGET_WAREHOUSE_ID { get; set; }

        [StringLength(1000)]
        public string TARGET_COMMENT { get; set; }

        public decimal? CUSTOMER_ID { get; set; }

        [StringLength(300)]
        public string PROJECT_INFO { get; set; }

        public DateTime? IO_CONFIRM_DATE { get; set; }

        [StringLength(200)]
        public string SUPPLIER_NAME { get; set; }

        public decimal? PROVINCE_ID { get; set; }

        public decimal? CITY_ID { get; set; }

        public decimal? DISTRICT_ID { get; set; }

        [StringLength(300)]
        public string ADDRESS { get; set; }

        [StringLength(50)]
        public string CONTACT_NAME { get; set; }

        [StringLength(50)]
        public string PHONE { get; set; }

        public decimal? IS_QC { get; set; }

        [StringLength(1000)]
        public string QC_RESULT { get; set; }

        public decimal? QC_EMPLOYEE_ID { get; set; }

        public DateTime? QC_DATE { get; set; }

        public decimal? WAREHOUSE_POSITION_ID { get; set; }

        public decimal? TARGET_WAREHOUSE_POSITION_ID { get; set; }

        public decimal? SALES_CONTRACT_ID { get; set; }

        [StringLength(50)]
        public string CONTRACT_NO { get; set; }

        public decimal? RECEIVE_EMPLOYEE_ID { get; set; }

        public decimal? LINK_STOCK_IO_ID { get; set; }

        public DateTime? IO_DATE { get; set; }
    }
}
