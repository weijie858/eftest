namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.OA_PROJECT_BILL")]
    public partial class OA_PROJECT_BILL
    {
        [Key]
        [Column(Order = 0)]
        public decimal OA_ID { get; set; }

        [StringLength(50)]
        public string PROJECT_NO { get; set; }

        [StringLength(300)]
        public string PROJECT_NAME { get; set; }

        [StringLength(50)]
        public string EMPLOYEE_NAME { get; set; }

        [StringLength(50)]
        public string EMPLOYEE_NO { get; set; }

        [StringLength(50)]
        public string SALES_CONTRACT_NO { get; set; }

        public decimal? AMOUNT { get; set; }

        public decimal? REAL_AMOUNT { get; set; }

        public DateTime? RECEIVE_DATE { get; set; }

        [StringLength(50)]
        public string PAY_TYPE { get; set; }

        [StringLength(50)]
        public string ACCOUNT_FLAG { get; set; }

        [StringLength(50)]
        public string BILL_TYPE { get; set; }

        [StringLength(50)]
        public string AMOUNT_TYPE { get; set; }

        [StringLength(50)]
        public string IS_FUNDS_POOL { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal IS_SYNC { get; set; }
    }
}
