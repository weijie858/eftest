namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.WM_STOCK_IO_ITEM")]
    public partial class WM_STOCK_IO_ITEM
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal STOCK_IO_ID { get; set; }

        public decimal STOCK_IO_BATCH_ID { get; set; }

        public decimal? STOCK_ITEM_ID { get; set; }

        [StringLength(500)]
        public string SN { get; set; }

        public decimal? STOCK_BATCH_ID { get; set; }

        public decimal? STOCK_IO_APPLY_ID { get; set; }

        [StringLength(500)]
        public string MAINTENANCE_MONTH_REMARK { get; set; }
    }
}
