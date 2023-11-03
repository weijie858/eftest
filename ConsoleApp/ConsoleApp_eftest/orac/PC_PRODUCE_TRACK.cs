namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PC_PRODUCE_TRACK")]
    public partial class PC_PRODUCE_TRACK
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal EMPLOYEE_ID { get; set; }

        public DateTime? FINISH_DATE { get; set; }

        public decimal STATUS { get; set; }

        public decimal PURCHASE_ORDER_ID { get; set; }

        [StringLength(2000)]
        public string TRACK_CONTENT { get; set; }

        [StringLength(2000)]
        public string REMARK { get; set; }

        public decimal? EMPLOYEE_STATUS { get; set; }

        public DateTime? START_DATE { get; set; }

        public decimal? APPLY_EMPLOYEE_ID { get; set; }

        public decimal? CREATE_EMPLOYEE_ID { get; set; }
    }
}
