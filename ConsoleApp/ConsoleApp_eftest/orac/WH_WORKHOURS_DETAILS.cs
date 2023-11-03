namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.WH_WORKHOURS_DETAILS")]
    public partial class WH_WORKHOURS_DETAILS
    {
        public decimal ID { get; set; }

        public int REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime? REC_CREATE_DATE { get; set; }

        public decimal? REC_MODIFIER { get; set; }

        public DateTime? REC_MODIFY_DATE { get; set; }

        public decimal? PROJECT_ID { get; set; }

        [StringLength(1000)]
        public string REMARK { get; set; }

        public decimal? USERID { get; set; }

        public int EFFECTIVE_HOUR { get; set; }

        public decimal? MAIN_ID { get; set; }

        [StringLength(100)]
        public string PROJECT_NO { get; set; }

        [StringLength(300)]
        public string PROJECT_NAME { get; set; }

        public DateTime? REC_DATE { get; set; }

        [StringLength(50)]
        public string FLOW_ID { get; set; }

        public decimal? PROJECT_MANAGER_ID { get; set; }

        public int? STATUS { get; set; }

        [StringLength(28)]
        public string PROJECT_MANAGER_ICNUM { get; set; }

        public decimal? FROM_CONTRACT_ID { get; set; }
    }
}
