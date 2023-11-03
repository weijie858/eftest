namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.DING_TALK_USER")]
    public partial class DING_TALK_USER
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        [StringLength(100)]
        public string USER_ID { get; set; }

        [StringLength(100)]
        public string UNION_ID { get; set; }

        [StringLength(100)]
        public string USER_NAME { get; set; }

        [StringLength(100)]
        public string PHOTO_URL { get; set; }

        [StringLength(100)]
        public string MOBILE { get; set; }

        [StringLength(100)]
        public string TELEPHONE { get; set; }

        [StringLength(100)]
        public string JOB_NUMBER { get; set; }

        [StringLength(100)]
        public string TITLE { get; set; }

        [StringLength(100)]
        public string ORG_EMAIL { get; set; }

        [StringLength(100)]
        public string EMAIL { get; set; }

        [StringLength(100)]
        public string REMARK { get; set; }

        [StringLength(100)]
        public string DEPT_ID_LIST { get; set; }

        public decimal? DEPT_ORDER { get; set; }

        [StringLength(100)]
        public string HIRED_DATE { get; set; }

        public decimal? ADMIN { get; set; }

        public decimal? BOSS { get; set; }

        public decimal? LEADER { get; set; }

        public decimal? DEPT_ID { get; set; }

        [StringLength(100)]
        public string STATUS { get; set; }
    }
}
