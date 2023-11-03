namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PO_PURCHASE_CONTRACT_INVOICE")]
    public partial class PO_PURCHASE_CONTRACT_INVOICE
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal PURCHASE_CONTRACT_ID { get; set; }

        public DateTime RECEIVE_DATE { get; set; }

        [Required]
        [StringLength(50)]
        public string INVOICE_NO { get; set; }

        public decimal AMOUNT { get; set; }

        public decimal PERCENT { get; set; }

        [StringLength(300)]
        public string IMG_URL { get; set; }

        public decimal STATUS { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }

        public decimal? INVOICE_TYPE { get; set; }

        [StringLength(100)]
        public string RATE { get; set; }
    }
}
