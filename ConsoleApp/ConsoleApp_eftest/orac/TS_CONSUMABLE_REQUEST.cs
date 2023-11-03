namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.TS_CONSUMABLE_REQUEST")]
    public partial class TS_CONSUMABLE_REQUEST
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        [StringLength(200)]
        public string RECEIVER { get; set; }

        [StringLength(50)]
        public string TELPHONE { get; set; }

        public decimal ADDRESS_PROVINCE_ID { get; set; }

        public decimal ADDRESS_CITY_ID { get; set; }

        public decimal ADDRESS_DISTRICT_ID { get; set; }

        [StringLength(200)]
        public string ADDRESS { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        public decimal QUANTITY { get; set; }

        public decimal? STATUS { get; set; }

        public decimal? AMOUNT { get; set; }

        public DateTime? DELIVERY_DATE { get; set; }

        public DateTime? REQUEST_DATE { get; set; }

        public decimal? REQUEST_EMPLOYEE_ID { get; set; }

        public DateTime? REQUEST_DELIVERY_DATE { get; set; }

        public DateTime? SIGN_IN_DATE { get; set; }

        public decimal? DELIVERY_EMPLOYEE_ID { get; set; }
    }
}
