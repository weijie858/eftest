namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PO_ICCARDPURCHASE_APPLY")]
    public partial class PO_ICCARDPURCHASE_APPLY
    {
        [Key]
        [Column(Order = 0)]
        public decimal ID { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal REC_DELETED { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal REC_CREATOR { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime REC_CREATE_DATE { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal REC_MODIFIER { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime REC_MODIFY_DATE { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal REC_VERSION { get; set; }

        public decimal? SALES_CONTRACT_ID { get; set; }

        public decimal? APPLY_EMPLOYEE_ID { get; set; }

        public decimal? PURCHASE_CONTRACT_ID { get; set; }

        [StringLength(2000)]
        public string ATTACH_IDS { get; set; }

        public decimal? PURCHASE_EMPLOYEE_ID { get; set; }

        public decimal? COMPANY_ID { get; set; }

        public DateTime? APPLY_DATE { get; set; }

        public DateTime? EXPECT_DATE { get; set; }

        public decimal? APPLY_TYPE { get; set; }

        [StringLength(300)]
        public string PURCHASE_APPLY_NAME { get; set; }

        public decimal? IS_SPECIFIC_SUPPLIER { get; set; }

        [StringLength(200)]
        public string SPECIFIC_SUPPLIER { get; set; }

        public decimal? ITEM_TYPE { get; set; }

        public decimal? AMOUNT { get; set; }

        public decimal? STATUS { get; set; }

        [StringLength(1000)]
        public string REMARK { get; set; }

        [StringLength(50)]
        public string APPLY_NO { get; set; }

        public decimal? DEPARTMENT_ID { get; set; }

        public decimal? VERSION { get; set; }

        public decimal? SOURCE_ID { get; set; }

        [StringLength(300)]
        public string RECEIVEINFO { get; set; }

        public decimal? CARDTYPE { get; set; }

        [StringLength(20)]
        public string BANKCODE { get; set; }

        [StringLength(100)]
        public string BANKNAME { get; set; }
    }
}
