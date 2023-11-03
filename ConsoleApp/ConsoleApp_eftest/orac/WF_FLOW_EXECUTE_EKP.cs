namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.WF_FLOW_EXECUTE_EKP")]
    public partial class WF_FLOW_EXECUTE_EKP
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal? FLOW_EXECUTE_ID { get; set; }

        [StringLength(100)]
        public string FLOW_EKP_ID { get; set; }

        public decimal? STATUS { get; set; }

        [StringLength(300)]
        public string FLOW_EKP_MODEL_ID { get; set; }
    }
}
