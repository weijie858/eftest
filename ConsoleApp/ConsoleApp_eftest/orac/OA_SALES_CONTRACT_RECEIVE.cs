namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.OA_SALES_CONTRACT_RECEIVE")]
    public partial class OA_SALES_CONTRACT_RECEIVE
    {
        [Key]
        public decimal OA_ID { get; set; }

        [StringLength(50)]
        public string CONTRACT_NO { get; set; }

        [StringLength(200)]
        public string CONTRACT_NAME { get; set; }

        public decimal? RECEIVE_AMOUNT { get; set; }

        public decimal? OA_CONTRACT_ID { get; set; }

        [StringLength(200)]
        public string CUSTOMER_NAME { get; set; }

        [StringLength(50)]
        public string SALES_ACCOUNT { get; set; }

        [StringLength(50)]
        public string SALES_NAME { get; set; }

        public DateTime? RECEIVE_DATE { get; set; }

        public DateTime? RECORD_DATE { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        public decimal? IS_SYNC { get; set; }
    }
}
