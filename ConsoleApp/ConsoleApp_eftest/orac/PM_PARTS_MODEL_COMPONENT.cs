namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PM_PARTS_MODEL_COMPONENT")]
    public partial class PM_PARTS_MODEL_COMPONENT
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal PARTS_MODEL_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string COMPONENT_TYPE { get; set; }

        [Required]
        [StringLength(100)]
        public string COMPONENT_NAME { get; set; }

        [StringLength(50)]
        public string FACTORY_MODEL { get; set; }

        [StringLength(200)]
        public string SPECIFICATION { get; set; }

        public decimal NUM { get; set; }

        [StringLength(50)]
        public string UNIT { get; set; }

        public decimal SORT_INDEX { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }
    }
}
