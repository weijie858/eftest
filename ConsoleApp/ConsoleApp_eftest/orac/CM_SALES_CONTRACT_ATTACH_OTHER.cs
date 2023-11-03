namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.CM_SALES_CONTRACT_ATTACH_OTHER")]
    public partial class CM_SALES_CONTRACT_ATTACH_OTHER
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal SALES_CONTRACT_ID { get; set; }

        public DateTime CONFIRM_DATE { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        public decimal? ATTACH_TYPE { get; set; }

        public decimal? COMPANY_ID { get; set; }
    }
}
