namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.CRM_SUPPLIER")]
    public partial class CRM_SUPPLIER
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
        public string SUPPLIER_NAME { get; set; }

        [StringLength(200)]
        public string ADDRESS { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }

        [StringLength(50)]
        public string TAX_NUMBER { get; set; }

        [StringLength(50)]
        public string BANK_ACCOUNT { get; set; }

        [StringLength(50)]
        public string BANK { get; set; }

        [StringLength(50)]
        public string TELPHONE { get; set; }

        [StringLength(300)]
        public string REGISTER_ADDRESS { get; set; }

        public decimal? STATUS { get; set; }

        [StringLength(20)]
        public string CONTACT_NAME { get; set; }

        [StringLength(20)]
        public string LEGAL_REPRESENTATIVE { get; set; }

        [StringLength(20)]
        public string COMPANY_NATURE { get; set; }

        [StringLength(20)]
        public string COMPANY_SIZE { get; set; }

        public decimal? REGISTER_MONEY { get; set; }

        public decimal? EMPLOYEE_NUMBER { get; set; }

        [StringLength(20)]
        public string SALES_AREA { get; set; }

        public decimal? PUBLICITY { get; set; }

        public DateTime? EXPIRE_TIME { get; set; }

        [StringLength(300)]
        public string MAIN_PRODUCE_DEVICE { get; set; }

        [StringLength(300)]
        public string MAIN_CHECK_DEVICE { get; set; }

        [StringLength(300)]
        public string QUALITY_ORGANIZATION { get; set; }

        [StringLength(20)]
        public string GRADE { get; set; }

        [StringLength(200)]
        public string ATTACHIDS { get; set; }

        [StringLength(20)]
        public string QUALITY_INSTITUTIONS { get; set; }

        [StringLength(20)]
        public string QUALITY_DIRECTOR { get; set; }

        [StringLength(20)]
        public string PROFESSIONAL_CHECKER { get; set; }

        [StringLength(20)]
        public string QUALITY_CONTROL_POINTS { get; set; }

        [StringLength(20)]
        public string QUALITY_RECORD { get; set; }

        [StringLength(50)]
        public string QUALITY_TRAINING { get; set; }

        [StringLength(100)]
        public string QUALITY_SYSTEM { get; set; }

        public decimal? SUPPLIER_TYPE { get; set; }
    }
}
