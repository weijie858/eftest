namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.MT_CUSTOMER_SERVICE_RECORD")]
    public partial class MT_CUSTOMER_SERVICE_RECORD
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal CREATE_EMPLOYEE_ID { get; set; }

        public DateTime REQUEST_DATE { get; set; }

        public decimal? PROVINCE_ID { get; set; }

        public decimal? CITY_ID { get; set; }

        public decimal? DISTRICT_ID { get; set; }

        [StringLength(50)]
        public string LINK_MAN { get; set; }

        [StringLength(50)]
        public string LINK_PHONE { get; set; }

        public decimal? CUSTOMER_ID { get; set; }

        [StringLength(50)]
        public string DEVICE_SN { get; set; }

        [StringLength(2000)]
        public string PROBLEM_DESC { get; set; }

        [StringLength(200)]
        public string DEVICE_LOCATION { get; set; }

        public decimal? SERVICE_EMPLOYEE_ID { get; set; }

        [StringLength(2000)]
        public string HANDLE_DESC { get; set; }

        [StringLength(500)]
        public string HANDLE_RESULT { get; set; }

        public DateTime? FINISH_DATE { get; set; }

        public decimal? IS_CHANGE_PARTS { get; set; }

        public decimal? RECORD_SOURCE { get; set; }

        public decimal STATUS { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        [StringLength(50)]
        public string RECORD_NO { get; set; }

        [StringLength(50)]
        public string ADDRESS_NAME { get; set; }

        [StringLength(50)]
        public string ADDRESS_NO { get; set; }

        public decimal? ADDRESS_PROVINCE_ID { get; set; }

        public decimal? ADDRESS_CITY_ID { get; set; }

        public decimal? ADDRESS_DISTRICT_ID { get; set; }

        [StringLength(300)]
        public string ADDRESS_ADDRESS { get; set; }

        [StringLength(50)]
        public string ADDRESS_CONTACT_NAME { get; set; }

        [StringLength(50)]
        public string ADDRESS_PHONE { get; set; }
    }
}
