namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PC_PRODUCE_TRACK_EMPLOYEE")]
    public partial class PC_PRODUCE_TRACK_EMPLOYEE
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal PRODUCE_TRACK_ID { get; set; }

        public decimal EMPLOYEE_ID { get; set; }

        public string PRODUCE_PROCESS_RECORD { get; set; }

        public decimal? PLAN_WORKING_HOURS { get; set; }

        public decimal? CONFIRM_WORKING_HOURS { get; set; }

        public decimal? SPECIAL_HOURS { get; set; }

        public decimal? SATISFACTION { get; set; }

        public decimal? QUALITY_PENALTY { get; set; }

        [StringLength(2000)]
        public string EVALUATE_RESULT { get; set; }

        [StringLength(2000)]
        public string REMARK { get; set; }

        public decimal? STATUS { get; set; }

        public decimal? TRAVEL_EXPENSE { get; set; }

        public decimal? HOTEL_EXPENSE { get; set; }

        public decimal? TRAFFIC_EXPENSE { get; set; }

        public decimal? ACTIVITY_EXPENSE { get; set; }

        public decimal? OFFICE_EXPENSE { get; set; }

        public decimal? OTHER_EXPENSE { get; set; }

        public decimal? TRAVEL_WORKING_HOURS { get; set; }

        public decimal? FREE_WORKING_HOURS { get; set; }

        public DateTime? BILLING_DATE { get; set; }

        public DateTime? ESTIMATE_START_DATE { get; set; }

        public DateTime? ESTIMATE_FINISH_DATE { get; set; }

        public DateTime? ESTIMATE_REPLY_DATE { get; set; }

        public DateTime? ACTUAL_ORDER_DATE { get; set; }

        public DateTime? ACTUAL_START_DATE { get; set; }

        public DateTime? ACTUAL_FINISH_DATE { get; set; }

        public DateTime? ACTUAL_REPLY_DATE { get; set; }
    }
}
