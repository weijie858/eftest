namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.CM_SALES_PLAN_DEVICE")]
    public partial class CM_SALES_PLAN_DEVICE
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal? SALES_PLAN_ID { get; set; }

        public decimal? DEVICE_MODEL_ID { get; set; }

        [StringLength(50)]
        public string OPERATING_SYSTEM { get; set; }

        [StringLength(300)]
        public string DEVICE_PICTURE_URL { get; set; }

        public decimal? QUANTITY { get; set; }

        public decimal? PRICE { get; set; }

        [StringLength(300)]
        public string REMARK { get; set; }
    }
}
