namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.RELATIONSHIP")]
    public partial class RELATIONSHIP
    {
        public Guid ID { get; set; }

        [StringLength(100)]
        public string DESCRIPTION { get; set; }

        [Required]
        [StringLength(100)]
        public string KEY { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal? FIRSTID { get; set; }

        public decimal? SECONDID { get; set; }

        public decimal? THIRDID { get; set; }

        [StringLength(100)]
        public string EXTENDINFO { get; set; }
    }
}
