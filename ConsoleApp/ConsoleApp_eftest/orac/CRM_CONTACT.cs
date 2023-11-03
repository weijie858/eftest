namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.CRM_CONTACT")]
    public partial class CRM_CONTACT
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal ORG_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string CONTACT_NAME { get; set; }

        [StringLength(50)]
        public string POSITION { get; set; }

        [StringLength(50)]
        public string MOBILE { get; set; }

        [StringLength(50)]
        public string EMAIL { get; set; }

        [StringLength(200)]
        public string ADDRESS { get; set; }

        public decimal SORT_INDEX { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }

        public decimal? COMPANY_ID { get; set; }
    }
}
