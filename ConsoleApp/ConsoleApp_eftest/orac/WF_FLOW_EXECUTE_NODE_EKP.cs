namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.WF_FLOW_EXECUTE_NODE_EKP")]
    public partial class WF_FLOW_EXECUTE_NODE_EKP
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal? FLOW_EXECUTE_ID { get; set; }

        [StringLength(500)]
        public string FLOW_EKP_ID { get; set; }

        [StringLength(500)]
        public string FD_NODE_NAME { get; set; }

        [StringLength(500)]
        public string FD_NODE_ID { get; set; }

        public DateTime? FD_CREATE_TIME { get; set; }

        public DateTime? FD_WORK_TIME { get; set; }

        [StringLength(500)]
        public string FD_ACTION_INFO { get; set; }

        [StringLength(500)]
        public string FD_ACTION_NAME { get; set; }

        [StringLength(500)]
        public string FD_AUDIT_NOTE { get; set; }

        [StringLength(500)]
        public string FD_HANDLER { get; set; }
    }
}
