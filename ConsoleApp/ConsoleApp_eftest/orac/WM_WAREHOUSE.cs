namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.WM_WAREHOUSE")]
    public partial class WM_WAREHOUSE
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        [Required]
        [StringLength(50)]
        public string WAREHOUSE_NAME { get; set; }

        public decimal? ADDRESS_PROVINCE_ID { get; set; }

        public decimal? ADDRESS_CITY_ID { get; set; }

        public decimal? ADDRESS_DISTRICT_ID { get; set; }

        [StringLength(200)]
        public string ADDRESS { get; set; }

        public decimal? STATUS { get; set; }

        public decimal? QUALITY { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }

        [StringLength(50)]
        public string WAREHOUSE_CODE { get; set; }

        public decimal? LINK_SUPPLIER_ID { get; set; }

        public decimal? WAREHOUSE_TYPE { get; set; }

        public decimal? COMPANY_ID { get; set; }
    }
}
