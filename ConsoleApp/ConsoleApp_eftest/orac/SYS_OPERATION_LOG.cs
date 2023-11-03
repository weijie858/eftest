namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.SYS_OPERATION_LOG")]
    public partial class SYS_OPERATION_LOG
    {
        public Guid ID { get; set; }

        [StringLength(20)]
        public string CONTROLLER { get; set; }

        [StringLength(20)]
        public string ACTION { get; set; }

        public decimal? REC_CREATOR { get; set; }

        public DateTime? REC_CREATE_DATE { get; set; }

        public decimal? REC_MODIFIER { get; set; }

        public DateTime? REC_MODIFY_DATE { get; set; }

        public decimal? REC_VERSION { get; set; }

        [StringLength(30)]
        public string REMARK { get; set; }

        [StringLength(20)]
        public string TYPE { get; set; }

        [StringLength(20)]
        public string RESULT { get; set; }

        public decimal? REC_DELETED { get; set; }

        [StringLength(50)]
        public string SYSTEMID { get; set; }
    }
}
