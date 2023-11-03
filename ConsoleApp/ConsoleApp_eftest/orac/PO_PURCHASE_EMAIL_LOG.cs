namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PO_PURCHASE_EMAIL_LOG")]
    public partial class PO_PURCHASE_EMAIL_LOG
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal SOURCE_ID { get; set; }

        public DateTime SEND_TIME { get; set; }

        [Required]
        [StringLength(300)]
        public string TARGET_EMAIL { get; set; }

        [Required]
        [StringLength(300)]
        public string SEND_EMAIL { get; set; }

        [Required]
        [StringLength(2000)]
        public string EMAIL_TITLE { get; set; }

        [Required]
        public string EMAIL_CONTENT { get; set; }

        public decimal STATUS { get; set; }

        [StringLength(1000)]
        public string REMARK { get; set; }

        [StringLength(2000)]
        public string EMAIL_ATTACH { get; set; }

        public decimal? SOURCE_TYPE { get; set; }
    }
}
