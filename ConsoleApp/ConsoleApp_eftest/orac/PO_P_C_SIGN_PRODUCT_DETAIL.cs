namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PO_P_C_SIGN_PRODUCT_DETAIL")]
    public partial class PO_P_C_SIGN_PRODUCT_DETAIL
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal P_C_SIGN_PRODUCT_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string PRODUCT_DETAIL_TYPE { get; set; }

        [Required]
        [StringLength(200)]
        public string PRODUCT_DETAIL_NAME { get; set; }

        [StringLength(300)]
        public string PRODUCT_DETAIL_SPEC { get; set; }

        public decimal PRICE { get; set; }

        public decimal REQUIRE_NUM { get; set; }

        public decimal TOTAL_PRICE { get; set; }

        [StringLength(300)]
        public string REMARK { get; set; }

        public decimal? P_O_PRODUCT_PARTS_ID { get; set; }

        public decimal PURCHASE_CONTRACT_ID { get; set; }

        public decimal? SOURCE_TYPE { get; set; }

        public decimal? SORT_INDEX { get; set; }
    }
}
