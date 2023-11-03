namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.BIZ_REC_WATER_DETAILS")]
    public partial class BIZ_REC_WATER_DETAILS
    {
        [StringLength(36)]
        public string ID { get; set; }

        [StringLength(36)]
        public string PID { get; set; }

        public decimal? CONTRACTID { get; set; }

        public decimal? REC_DELETED { get; set; }

        public decimal? REC_CREATOR { get; set; }

        public DateTime? REC_CREATE_DATE { get; set; }

        public decimal? REC_MODIFIER { get; set; }

        public DateTime? REC_MODIFY_DATE { get; set; }

        public decimal? AMOUNT { get; set; }
    }
}
