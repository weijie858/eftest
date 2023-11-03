namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.MT_CUSTOMER_SERVICE_ADDRESS")]
    public partial class MT_CUSTOMER_SERVICE_ADDRESS
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        [StringLength(50)]
        public string ADDRESS_NAME { get; set; }

        [StringLength(50)]
        public string ADDRESS_NO { get; set; }

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
        public string REMARK { get; set; }
    }
}
