namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PC_PRODUCE_MESSAGE")]
    public partial class PC_PRODUCE_MESSAGE
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal? SEND_EMPLOYEE_ID { get; set; }

        public decimal? RECEIVE_EMPLOYEE_ID { get; set; }

        public DateTime? SEND_DATE { get; set; }

        [StringLength(4000)]
        public string SEND_CONTENT { get; set; }

        public decimal? PRODUCE_SOURCE_ID { get; set; }

        public decimal? MESSAGE_TYPE { get; set; }

        public decimal? IS_READ { get; set; }
    }
}
