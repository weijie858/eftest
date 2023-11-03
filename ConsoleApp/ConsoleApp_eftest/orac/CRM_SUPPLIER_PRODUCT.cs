namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.CRM_SUPPLIER_PRODUCT")]
    public partial class CRM_SUPPLIER_PRODUCT
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        [StringLength(20)]
        public string PAY_TIME { get; set; }

        [StringLength(20)]
        public string DELIVERY_TIME { get; set; }

        public decimal? YEARS_SALES { get; set; }

        [StringLength(20)]
        public string PRODUCT_TYPE { get; set; }

        public decimal? SUPPLIER_ID { get; set; }
    }
}
