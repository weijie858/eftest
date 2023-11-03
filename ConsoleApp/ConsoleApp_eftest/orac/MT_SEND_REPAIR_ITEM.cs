namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.MT_SEND_REPAIR_ITEM")]
    public partial class MT_SEND_REPAIR_ITEM
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal? SEND_REPAIR_ID { get; set; }

        public decimal? MODEL_TYPE { get; set; }

        public decimal? MODEL_ID { get; set; }

        public decimal? PRODUCT_TYPE_ID { get; set; }

        [StringLength(300)]
        public string PRODUCT_NAME { get; set; }

        [StringLength(500)]
        public string PRODUCT_COMMENT { get; set; }

        public decimal? PRICE { get; set; }

        public decimal? QUANTITY { get; set; }

        public decimal? STATUS { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        [StringLength(200)]
        public string PARTS_SN { get; set; }

        [StringLength(200)]
        public string PARTS_FACTORY_SN { get; set; }

        [StringLength(200)]
        public string DEVICE_SN { get; set; }
    }
}
