namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.OA_PURCHASE")]
    public partial class OA_PURCHASE
    {
        public decimal ID { get; set; }

        public decimal OA_ID { get; set; }

        [StringLength(50)]
        public string COMPANY_CODE { get; set; }

        [StringLength(50)]
        public string SIGN_DATE { get; set; }

        [StringLength(50)]
        public string PURCHASE_NO { get; set; }

        [StringLength(200)]
        public string PURCHASE_NAME { get; set; }

        [StringLength(50)]
        public string PURCHASE_EMPLOYEE_ACCOUNT { get; set; }

        [StringLength(50)]
        public string OA_SUPPLIER_ID { get; set; }

        [StringLength(50)]
        public string AMOUNT { get; set; }

        [StringLength(50)]
        public string EXPECT_DATE { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }

        public decimal OPERATE_MARK { get; set; }

        public decimal IS_SYNC { get; set; }

        [StringLength(50)]
        public string OA_SYS_NAME { get; set; }
    }
}
