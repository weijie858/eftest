namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PM_DEVICE_MODEL_PARTS_TYPE")]
    public partial class PM_DEVICE_MODEL_PARTS_TYPE
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal DEVICE_MODEL_ID { get; set; }

        public decimal PARTS_TYPE_ID { get; set; }

        public decimal REQUIRE_NUM { get; set; }

        public decimal IS_NEED { get; set; }

        public decimal? IS_MULTI { get; set; }
    }
}
