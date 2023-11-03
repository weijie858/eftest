namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.TS_SALES_DELIVERY_FEE")]
    public partial class TS_SALES_DELIVERY_FEE
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal? SALES_DELIVERY_ID { get; set; }

        public decimal? DELIVERY_FEE_TYPE { get; set; }

        public decimal? EXPRESS_TYPE { get; set; }

        [StringLength(50)]
        public string EXPRESS_NO { get; set; }

        public decimal? DELIVERY_FEE { get; set; }

        public decimal? STATUS { get; set; }

        [StringLength(300)]
        public string REMARK { get; set; }
    }
}
