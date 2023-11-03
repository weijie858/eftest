namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.WH_WORKHOURS_MAIN")]
    public partial class WH_WORKHOURS_MAIN
    {
        public decimal ID { get; set; }

        public int REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime? REC_CREATE_DATE { get; set; }

        public decimal? REC_MODIFIER { get; set; }

        public DateTime? REC_MODIFY_DATE { get; set; }

        public int? REC_YEAR { get; set; }

        public int? REC_MONTH { get; set; }

        public int? REC_DAY { get; set; }

        public int? STATUS { get; set; }

        [StringLength(20)]
        public string REC_CREATOR_ICNUM { get; set; }

        public DateTime? REC_DATE { get; set; }

        public decimal TOTAL_HOUR { get; set; }

        [StringLength(50)]
        public string FLOW_ID { get; set; }

        public int? TYPE { get; set; }

        public decimal? CONTRACTID { get; set; }

        public decimal? CATEGORY { get; set; }

        public decimal? FROM_CONTRACT_ID { get; set; }
    }
}
