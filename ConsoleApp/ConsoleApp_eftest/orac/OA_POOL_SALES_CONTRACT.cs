namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.OA_POOL_SALES_CONTRACT")]
    public partial class OA_POOL_SALES_CONTRACT
    {
        public decimal ID { get; set; }

        public decimal OA_ID { get; set; }

        public decimal SALES_CONTRACT_OA_ID { get; set; }

        public decimal POOL_OA_ID { get; set; }

        public decimal OPERATE_MARK { get; set; }

        public decimal IS_SYNC { get; set; }
    }
}
