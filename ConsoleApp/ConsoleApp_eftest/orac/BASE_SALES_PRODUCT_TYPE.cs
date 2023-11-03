namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.BASE_SALES_PRODUCT_TYPE")]
    public partial class BASE_SALES_PRODUCT_TYPE
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal PRODUCT_TYPE { get; set; }

        [Required]
        [StringLength(50)]
        public string PRODUCT_TYPE_NAME { get; set; }

        public decimal SORT_INDEX { get; set; }

        [StringLength(300)]
        public string REMARK { get; set; }

        public decimal STATUS { get; set; }
    }
}
