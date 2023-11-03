namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.CM_SP_DEVICE_PARTS_MODEL")]
    public partial class CM_SP_DEVICE_PARTS_MODEL
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal? SALES_PLAN_ID { get; set; }

        public decimal? SALES_PLAN_DEVICE_ID { get; set; }

        public decimal? SP_DEVICE_PARTS_TYPE_ID { get; set; }

        public decimal? PARTS_MODEL_ID { get; set; }

        [StringLength(300)]
        public string PARTS_COMMENT { get; set; }
    }
}
