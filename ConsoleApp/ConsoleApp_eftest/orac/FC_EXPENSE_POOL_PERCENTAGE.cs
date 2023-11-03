namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.FC_EXPENSE_POOL_PERCENTAGE")]
    public partial class FC_EXPENSE_POOL_PERCENTAGE
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal SALES_TYPE { get; set; }

        public decimal PRODUCT_TYPE_ID { get; set; }

        public decimal PERCENTAGE { get; set; }

        [StringLength(300)]
        public string REMARK { get; set; }

        public decimal? EXPENSE_POOL_ID { get; set; }

        [StringLength(3000)]
        public string PROJECT_AREA_IDS { get; set; }
    }
}
