namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PO_PURCHASE_CONTRACT")]
    public partial class PO_PURCHASE_CONTRACT
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal? PURCHASE_ORDER_ID { get; set; }

        [StringLength(50)]
        public string PURCHASE_ORDER_NO { get; set; }

        public decimal? PURCHASE_EMPLOYEE_ID { get; set; }

        public decimal SUPPLIER_ID { get; set; }

        public decimal SUPPLIER_CONTACT_ID { get; set; }

        public decimal? COMPANY_ID { get; set; }

        public decimal? CREATE_COMPANY_ID { get; set; }

        public decimal? SUB_COMPANY_ID { get; set; }

        public decimal PURCHASE_TYPE { get; set; }

        [StringLength(50)]
        public string PURCHASE_NO { get; set; }

        public DateTime SIGN_DATE { get; set; }

        public DateTime EXPECT_DATE { get; set; }

        public DateTime? PAY_DATE { get; set; }

        public DateTime? RECEIVE_DATE { get; set; }

        public decimal? BELONG_YEAR { get; set; }

        [StringLength(500)]
        public string PURCHASE_NAME { get; set; }

        public decimal? AMOUNT { get; set; }

        public decimal? IS_SEND_EMAIL { get; set; }

        public decimal? DISCOUNT_AMOUNT { get; set; }

        public decimal? IS_SUBCONTRACT { get; set; }

        [StringLength(100)]
        public string SUPPLIER_NAME { get; set; }

        public decimal STATUS { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }

        public decimal? DEPARTMENT_ID { get; set; }

        public decimal? FRAME { get; set; }

        [StringLength(100)]
        public string PURCHASE_NO_INNER { get; set; }

        [StringLength(10)]
        public string SOURCE { get; set; }

        public decimal? IS_WRITEOFF { get; set; }

        public decimal? PURCHASE_PRODUCT_TYPE { get; set; }

        public decimal? IS_ORDER { get; set; }

        public decimal? ISCONSULTING { get; set; }

        [StringLength(100)]
        public string REMARK2 { get; set; }

        public decimal? AUTO_IN_OUT_STOCK { get; set; }
    }
}
