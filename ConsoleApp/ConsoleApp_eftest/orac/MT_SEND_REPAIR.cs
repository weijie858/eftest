namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.MT_SEND_REPAIR")]
    public partial class MT_SEND_REPAIR
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        [StringLength(20)]
        public string SEND_REPAIR_NO { get; set; }

        public decimal? WAREHOUSE_ID { get; set; }

        public decimal? REQUEST_EMPLOYEE_ID { get; set; }

        public DateTime? REQUEST_DATE { get; set; }

        [StringLength(200)]
        public string EXPRESS_NO { get; set; }

        public decimal? STATUS { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

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

        [StringLength(200)]
        public string SEND_REPAIR_TITLE { get; set; }

        public decimal? BACK_PROVINCE_ID { get; set; }

        public decimal? BACK_CITY_ID { get; set; }

        public decimal? BACK_DISTRICT_ID { get; set; }

        [StringLength(300)]
        public string BACK_ADDRESS { get; set; }

        [StringLength(50)]
        public string BACK_CONTACT_NAME { get; set; }

        [StringLength(50)]
        public string BACK_PHONE { get; set; }

        [StringLength(200)]
        public string BACK_EXPRESS_NO { get; set; }
    }
}
