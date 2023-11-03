namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.DM_COMPONENT")]
    public partial class DM_COMPONENT
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal COMPONENT_MODEL_ID { get; set; }

        [Required]
        [StringLength(20)]
        public string COMPONENT_SN { get; set; }

        public DateTime? RECEIVE_DATE { get; set; }

        public DateTime? EXPIRE_DATE { get; set; }

        public decimal STATUS { get; set; }

        public decimal QUALITY { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }

        public decimal DEVICE_ID { get; set; }

        public decimal? SOURCE_ID { get; set; }
    }
}
