namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.CRM_CUSTOMER")]
    public partial class CRM_CUSTOMER
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        [Required]
        [StringLength(200)]
        public string CUSTOMER_NAME { get; set; }

        [StringLength(50)]
        public string PINYIN { get; set; }

        [StringLength(50)]
        public string FAX { get; set; }

        [StringLength(50)]
        public string EMAIL { get; set; }

        public decimal? ADDRESS_PROVINCE_ID { get; set; }

        public decimal? ADDRESS_CITY_ID { get; set; }

        public decimal? ADDRESS_DISTRICT_ID { get; set; }

        [StringLength(200)]
        public string ADDRESS { get; set; }

        [StringLength(50)]
        public string TAX_NUMBER { get; set; }

        [StringLength(50)]
        public string BANK_ACCOUNT { get; set; }

        [StringLength(100)]
        public string BANK { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }

        [StringLength(200)]
        public string COMPANY_NAME { get; set; }

        [StringLength(50)]
        public string RANK { get; set; }

        [StringLength(100)]
        public string TELPHONE { get; set; }

        [StringLength(300)]
        public string REGISTER_ADDRESS { get; set; }

        public decimal? ORG_TYPE_CODE { get; set; }

        [StringLength(50)]
        public string INVOICE_TELPHONE { get; set; }

        public decimal? COMPANY_ID { get; set; }

        [StringLength(50)]
        public string OA_CUSTOMERID { get; set; }

        public decimal? CUSTOMER_TYPE { get; set; }

        public decimal? CUSTOMER_CLASS { get; set; }
    }
}
