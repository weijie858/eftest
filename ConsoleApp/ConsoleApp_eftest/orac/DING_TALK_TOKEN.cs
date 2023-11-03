namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.DING_TALK_TOKEN")]
    public partial class DING_TALK_TOKEN
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        [Required]
        [StringLength(100)]
        public string TEMPLATE_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string ACCESS_TOKEN { get; set; }

        public DateTime EXPIRATION_TIME { get; set; }

        [Required]
        [StringLength(100)]
        public string REFRESH_TOKEN { get; set; }

        [Required]
        [StringLength(100)]
        public string JS_API_TICKET { get; set; }

        public DateTime JS_API_TICKET_EXPIRATION_TIME { get; set; }

        public decimal COMPANY_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string APP_KEY { get; set; }

        [Required]
        [StringLength(100)]
        public string APP_SECRET { get; set; }

        public decimal AGENT_ID { get; set; }
    }
}
