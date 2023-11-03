namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.OA_SALES_CONTRACT_INVOICE")]
    public partial class OA_SALES_CONTRACT_INVOICE
    {
        [Key]
        public decimal OA_ID { get; set; }

        [StringLength(50)]
        public string CONTRACT_NO { get; set; }

        [StringLength(200)]
        public string CONTRACT_NAME { get; set; }

        [StringLength(200)]
        public string INVOICE_COMPANY_NAME { get; set; }

        [StringLength(200)]
        public string CUSTOMER_NAME { get; set; }

        [StringLength(50)]
        public string INVOICE_TYPE { get; set; }

        [StringLength(200)]
        public string INVOICE_NO { get; set; }

        [StringLength(200)]
        public string INVOICE_NAME { get; set; }

        public decimal? INVOICE_AMOUNT { get; set; }

        public decimal? RECEIVE_AMOUNT { get; set; }

        public DateTime? INVOICE_DATE { get; set; }

        [StringLength(50)]
        public string PAYMENT_TYPE { get; set; }

        [StringLength(500)]
        public string BANK_AND_ACCOUNT { get; set; }

        [StringLength(50)]
        public string EMPLOYEE_ACCOUNT { get; set; }

        [StringLength(50)]
        public string EMPLOYEE_NAME { get; set; }

        public DateTime? RECORD_DATE { get; set; }

        [StringLength(1000)]
        public string REMARK { get; set; }

        public decimal? IS_SYNC { get; set; }
    }
}
