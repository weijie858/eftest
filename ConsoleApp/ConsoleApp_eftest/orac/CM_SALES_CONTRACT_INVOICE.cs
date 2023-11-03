namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.CM_SALES_CONTRACT_INVOICE")]
    public partial class CM_SALES_CONTRACT_INVOICE
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal SALES_CONTRACT_ID { get; set; }

        public DateTime OPEN_DATE { get; set; }

        public decimal AMOUNT { get; set; }

        public decimal PERCENT { get; set; }

        [StringLength(1000)]
        public string IMG_URL { get; set; }

        public decimal STATUS { get; set; }

        [StringLength(2000)]
        public string REMARK { get; set; }

        [StringLength(300)]
        public string INVOICE_NO { get; set; }

        [StringLength(200)]
        public string INVOICE_COMPANY_NAME { get; set; }

        [StringLength(200)]
        public string CUSTOMER_NAME { get; set; }

        public decimal? INVOICE_TYPE { get; set; }

        [StringLength(50)]
        public string PAYMENT_TYPE { get; set; }

        [StringLength(50)]
        public string BANK_ACCOUNT { get; set; }

        public decimal? INVOICE_COMPANY_ID { get; set; }

        public decimal? CUSTOMER_ID { get; set; }

        public decimal? INVOICE_EMPLOYEE_ID { get; set; }

        [StringLength(50)]
        public string TAX_REGISTRATION_NUMBER { get; set; }

        [StringLength(50)]
        public string BANK { get; set; }

        [StringLength(100)]
        public string RECIPIENT_ADDRESS { get; set; }

        public decimal? QUANTITY { get; set; }

        [StringLength(50)]
        public string INVOICE_EMPLOYEE_NAME { get; set; }

        [StringLength(50)]
        public string RECIPIENT_NAME { get; set; }

        [StringLength(50)]
        public string RECIPIENT_PHONE { get; set; }

        [StringLength(100)]
        public string UPPER_AMOUNT { get; set; }

        [StringLength(50)]
        public string EXPECT_RETURN_MONEY_DATA { get; set; }

        [StringLength(100)]
        public string CUSTOMER_ADDRESS { get; set; }

        [StringLength(50)]
        public string CUSTOMER_TELPHONE { get; set; }

        [StringLength(300)]
        public string ERP_INVOICE_NO { get; set; }

        public decimal? IC_CARD { get; set; }

        public decimal? IS_PAY { get; set; }

        public DateTime? PAY_TIME { get; set; }

        [StringLength(100)]
        public string PERCENT2 { get; set; }

        public DateTime? CONFIRM_DATE { get; set; }

        public decimal? NO_CONTRACT_INVOICE { get; set; }

        public decimal? SALES_CONTRACT_INVOICE_ID { get; set; }
    }
}
