namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.SYS_PARAMETER_ENUM")]
    public partial class SYS_PARAMETER_ENUM
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        [StringLength(100)]
        public string NAME { get; set; }

        public decimal? KEY { get; set; }

        [StringLength(100)]
        public string VALUE { get; set; }

        public decimal? ENUM_TYPE { get; set; }

        public decimal? SORT { get; set; }

        public decimal? STATUS { get; set; }
    }
}
