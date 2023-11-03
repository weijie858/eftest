namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.BASE_EMAIL_TEMPLATE")]
    public partial class BASE_EMAIL_TEMPLATE
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal EMAIL_TYPE { get; set; }

        [Required]
        [StringLength(50)]
        public string TEMPLATE_NAME { get; set; }

        [Required]
        [StringLength(200)]
        public string TITLE { get; set; }

        [Required]
        [StringLength(4000)]
        public string CONTENT { get; set; }

        public decimal STATUS { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }
    }
}
