namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PC_PRODUCE_TASK_DETAIL")]
    public partial class PC_PRODUCE_TASK_DETAIL
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal PRODUCE_TASK_ID { get; set; }

        public decimal PRODUCE_TYPE { get; set; }

        public decimal PRODUCE_ID { get; set; }

        public decimal QC_STANDARD_ID { get; set; }

        public decimal QUANTITY { get; set; }

        public decimal QUALIFIED_QUANTITY { get; set; }

        public decimal? STATUS { get; set; }
    }
}
