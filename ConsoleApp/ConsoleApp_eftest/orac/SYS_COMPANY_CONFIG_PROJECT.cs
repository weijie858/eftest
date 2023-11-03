namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.SYS_COMPANY_CONFIG_PROJECT")]
    public partial class SYS_COMPANY_CONFIG_PROJECT
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal COMPANY_ID { get; set; }

        public decimal? KEY { get; set; }

        public decimal? VALUE { get; set; }

        public decimal? PERCENT { get; set; }

        public decimal? SORT { get; set; }
    }
}
