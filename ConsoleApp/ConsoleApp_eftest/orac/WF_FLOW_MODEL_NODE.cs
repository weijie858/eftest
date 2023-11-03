namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.WF_FLOW_MODEL_NODE")]
    public partial class WF_FLOW_MODEL_NODE
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal FLOW_MODEL_ID { get; set; }

        public decimal PARENT_NODE_ID { get; set; }

        [Required]
        [StringLength(20)]
        public string FLOW_NODE_TYPE { get; set; }

        [StringLength(100)]
        public string LOGICAL_OPERATION { get; set; }

        [Required]
        [StringLength(200)]
        public string NODE_NAME { get; set; }

        public decimal DEPARTMENT_ID { get; set; }

        public decimal POSITION_ID { get; set; }

        [StringLength(1000)]
        public string EMPLOYEE_IDS { get; set; }

        public decimal STEP { get; set; }

        public decimal NODE_OPTION { get; set; }

        public string CUSTOM_FORM { get; set; }

        [Required]
        [StringLength(100)]
        public string RESULT_OPERATION { get; set; }

        public decimal? POSITION_TYPE { get; set; }

        public decimal? INFLOW_CONDITION { get; set; }

        [StringLength(50)]
        public string INFLOW_OPERATOR { get; set; }

        [StringLength(300)]
        public string INFLOW_VALUE { get; set; }

        [StringLength(300)]
        public string MENU_POWER_STR { get; set; }

        [StringLength(300)]
        public string DATA_POWER_STR { get; set; }

        public decimal? SEND { get; set; }

        [StringLength(50)]
        public string REMARK { get; set; }
    }
}
