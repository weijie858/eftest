namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.WF_FLOW_EXECUTE")]
    public partial class WF_FLOW_EXECUTE
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal FLOW_MODEL_ID { get; set; }

        public decimal FLOW_TYPE { get; set; }

        [Required]
        [StringLength(200)]
        public string FLOW_NAME { get; set; }

        public decimal CREATE_EMPLOYEE_ID { get; set; }

        public DateTime START_DATE { get; set; }

        public DateTime? FINISH_DATE { get; set; }

        public string CUSTOM_FORM { get; set; }

        public decimal STATUS { get; set; }

        [StringLength(200)]
        public string LINK_ID { get; set; }

        public decimal? FLOW_FUNC { get; set; }

        [StringLength(500)]
        public string ATTACH_IDS { get; set; }

        [StringLength(50)]
        public string FLOW_NO { get; set; }

        public decimal? COMPANY_ID { get; set; }
    }
}
