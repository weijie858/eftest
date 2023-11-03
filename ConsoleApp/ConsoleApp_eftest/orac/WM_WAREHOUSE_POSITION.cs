namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.WM_WAREHOUSE_POSITION")]
    public partial class WM_WAREHOUSE_POSITION
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal WAREHOUSE_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string POSITION_NAME { get; set; }

        [StringLength(50)]
        public string POSITION_CODE { get; set; }

        public decimal? ADDRESS_PROVINCE_ID { get; set; }

        public decimal? ADDRESS_CITY_ID { get; set; }

        public decimal? ADDRESS_DISTRICT_ID { get; set; }

        [StringLength(200)]
        public string ADDRESS { get; set; }

        public decimal STATUS { get; set; }

        public decimal? LINK_SUPPLIER_ID { get; set; }
    }
}
