namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.BIP_SUBJECT")]
    public partial class BIP_SUBJECT
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal? SUBJECT_CODE { get; set; }

        [StringLength(300)]
        public string SUBJECT_NAME { get; set; }

        [StringLength(100)]
        public string CONTROL_DIRECTION { get; set; }

        [StringLength(100)]
        public string NUMBER_AMOUNT { get; set; }

        public decimal? SUBJECT_RANK { get; set; }

        [StringLength(100)]
        public string END_RANK { get; set; }

        [StringLength(100)]
        public string REMARK { get; set; }

        [StringLength(200)]
        public string HELP_COMPUTE { get; set; }

        [StringLength(200)]
        public string HELP_COMPUTE2 { get; set; }

        [StringLength(200)]
        public string HELP_COMPUTE3 { get; set; }

        [StringLength(200)]
        public string HELP_COMPUTE4 { get; set; }
    }
}
