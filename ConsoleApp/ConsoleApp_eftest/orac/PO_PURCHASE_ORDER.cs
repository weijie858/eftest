namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PO_PURCHASE_ORDER")]
    public partial class PO_PURCHASE_ORDER
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal SALES_CONTRACT_ID { get; set; }

        [Required]
        [StringLength(20)]
        public string ORDER_NO { get; set; }

        public DateTime ORDER_DATE { get; set; }

        public decimal ORDER_EMPLOYEE_ID { get; set; }

        public DateTime EXPECT_DATE { get; set; }

        public decimal SUPPLIER_ID { get; set; }

        public decimal SUPPLIER_CONTACT_ID { get; set; }

        [StringLength(50)]
        public string SUPPLIER_EMAIL { get; set; }

        public decimal IS_SEND_EMAIL { get; set; }

        public decimal STATUS { get; set; }

        public decimal IS_URGENT { get; set; }

        [StringLength(300)]
        public string REMARK { get; set; }

        public DateTime? FINISH_DATE { get; set; }

        public decimal? TOTAL_QUANTITY { get; set; }

        public decimal? PURCHASE_CONTRACT_ID { get; set; }

        public decimal? IS_REFORM { get; set; }

        public decimal? MODIFY_COUNT { get; set; }

        public DateTime? MODIFY_DATE { get; set; }

        public decimal? IS_COMPLETE { get; set; }

        public DateTime? COMPLETE_DATE { get; set; }

        public decimal? IS_PROTOTYPE { get; set; }

        [StringLength(200)]
        public string ORDER_NAME { get; set; }

        public decimal? PURCHASE_APPLY_ID { get; set; }

        public DateTime? EXPECT_COMPLETE_DATE { get; set; }

        public DateTime? SIGN_CONFIRM_DATE { get; set; }

        public decimal? ORDER_TYPE { get; set; }
    }
}
