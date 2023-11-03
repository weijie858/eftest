namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.OA_CONTRACT")]
    public partial class OA_CONTRACT
    {
        public decimal ID { get; set; }

        public decimal OA_ID { get; set; }

        [StringLength(50)]
        public string COMPANY_CODE { get; set; }

        [StringLength(50)]
        public string SIGN_DATE { get; set; }

        [StringLength(50)]
        public string CONTRACT_NO { get; set; }

        [StringLength(200)]
        public string CONTRACT_NAME { get; set; }

        [StringLength(50)]
        public string SALES_EMPLOYEE_ACCOUNT { get; set; }

        [StringLength(50)]
        public string OA_CUSTOMER_ID { get; set; }

        [StringLength(50)]
        public string AMOUNT { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }

        public decimal OPERATE_MARK { get; set; }

        public decimal IS_SYNC { get; set; }

        [StringLength(50)]
        public string OA_SYS_NAME { get; set; }
    }
}
