namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PO_PURCHASE_EMPLOYEE_AREA")]
    public partial class PO_PURCHASE_EMPLOYEE_AREA
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal EMPLOYEE_ID { get; set; }

        [StringLength(4000)]
        public string AREA_IDS { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        public decimal? PURCHASE_APPLY_TYPE { get; set; }
    }
}
