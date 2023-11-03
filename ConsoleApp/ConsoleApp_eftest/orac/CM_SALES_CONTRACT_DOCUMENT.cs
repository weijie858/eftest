namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.CM_SALES_CONTRACT_DOCUMENT")]
    public partial class CM_SALES_CONTRACT_DOCUMENT
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal SALES_CONTRACT_ID { get; set; }

        [Required]
        [StringLength(200)]
        public string FLIE_NAME { get; set; }

        public decimal COUNT { get; set; }

        public decimal? RECEIVE_EMPLOYEE_ID { get; set; }

        public DateTime? RECEIVE_DATE { get; set; }

        public decimal? STATUS { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }
    }
}
