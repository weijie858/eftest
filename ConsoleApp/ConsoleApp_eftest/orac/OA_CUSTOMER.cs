namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.OA_CUSTOMER")]
    public partial class OA_CUSTOMER
    {
        public decimal ID { get; set; }

        public decimal OA_ID { get; set; }

        [Required]
        [StringLength(200)]
        public string CUSTOMER_NAME { get; set; }

        [StringLength(50)]
        public string FAX { get; set; }

        [StringLength(50)]
        public string CITY { get; set; }

        [StringLength(200)]
        public string ADDRESS { get; set; }

        [StringLength(200)]
        public string COMPANY_NAME { get; set; }

        [StringLength(50)]
        public string TAX_NUMBER { get; set; }

        [StringLength(50)]
        public string BANK_ACCOUNT { get; set; }

        [StringLength(100)]
        public string BANK { get; set; }

        [StringLength(50)]
        public string RANK { get; set; }

        [StringLength(50)]
        public string CONTACT { get; set; }

        [StringLength(50)]
        public string CONTACT_TELPHONE { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }

        public decimal OPERATE_MARK { get; set; }

        public decimal IS_SYNC { get; set; }

        public decimal? CUSTOMER_ID { get; set; }

        [StringLength(50)]
        public string OA_SYS_NAME { get; set; }
    }
}
