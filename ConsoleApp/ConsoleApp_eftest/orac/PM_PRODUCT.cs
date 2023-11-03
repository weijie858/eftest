namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PM_PRODUCT")]
    public partial class PM_PRODUCT
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal PRODUCT_TYPE_ID { get; set; }

        [Required]
        [StringLength(200)]
        public string PRODUCT_NAME { get; set; }

        [StringLength(2000)]
        public string SPECIFICATION { get; set; }

        public decimal? BASE_LIMIT_PRICE { get; set; }

        public decimal? BASE_SALES_PRICE { get; set; }

        [StringLength(50)]
        public string UNIT { get; set; }

        public decimal STATUS { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        [StringLength(500)]
        public string PRODUCT_PICTURE_URL { get; set; }

        public decimal? LINK_DEVICE_MODEL_ID { get; set; }

        [StringLength(50)]
        public string PRODUCT_CODE { get; set; }

        [StringLength(200)]
        public string PRODUCT_MODEL { get; set; }

        [StringLength(200)]
        public string SUIT_COMMENT { get; set; }

        public decimal? PRODUCT_EXAMINE_STATUS { get; set; }

        public decimal? PRODUCT_MANAGER_ID { get; set; }

        [StringLength(500)]
        public string PARENT_PRODUCT_IDS { get; set; }

        [StringLength(500)]
        public string BUSINESS_DOMAIN_TAG_IDS { get; set; }

        public decimal? APPLICATION_TYPE_TAG_ID { get; set; }

        [StringLength(500)]
        public string CUSTOMER_GROUP_TAG_IDS { get; set; }

        public decimal? BUSINESS_SEGMENTS_TAG_ID { get; set; }

        public decimal? COMPANY_ID { get; set; }

        public decimal? ISSOFTWRITING { get; set; }

        [StringLength(100)]
        public string SOFTNAME { get; set; }

        public decimal? STANDARDNAME1_ID { get; set; }

        public string FUNCTIONMODULE { get; set; }

        public string BACKGROUND { get; set; }

        public decimal? STANDARDNAME2_ID { get; set; }
    }
}
