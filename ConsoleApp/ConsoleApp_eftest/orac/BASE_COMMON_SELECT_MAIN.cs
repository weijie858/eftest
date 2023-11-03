namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.BASE_COMMON_SELECT_MAIN")]
    public partial class BASE_COMMON_SELECT_MAIN
    {
        public decimal ID { get; set; }

        public decimal? REC_DELETED { get; set; }

        public decimal? REC_CREATOR { get; set; }

        public DateTime? REC_CREATE_DATE { get; set; }

        public decimal? REC_MODIFIER { get; set; }

        public DateTime? REC_MODIFY_DATE { get; set; }

        public decimal? REC_VERSION { get; set; }

        public decimal? PID { get; set; }

        [StringLength(20)]
        public string CODE { get; set; }

        [StringLength(100)]
        public string CODETEXT { get; set; }

        public decimal? ITEM_TYPE { get; set; }

        public decimal? SORT_INDEX { get; set; }
    }
}
