namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.SYS_MILESTONE")]
    public partial class SYS_MILESTONE
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal COMPANY_ID { get; set; }

        public decimal? SORT { get; set; }

        [StringLength(100)]
        public string SECTION_NAME { get; set; }

        public decimal? COST_TYPE { get; set; }

        [StringLength(100)]
        public string PERCENT { get; set; }

        public decimal? COST_RANGE { get; set; }

        public decimal? BELONG_MODULE { get; set; }

        public decimal? MUST { get; set; }

        public decimal? KEY { get; set; }

        public decimal? STATUS { get; set; }
    }
}
