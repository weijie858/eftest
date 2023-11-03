namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.BIP_RECEIVE_CHANGE_SOURCE")]
    public partial class BIP_RECEIVE_CHANGE_SOURCE
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal? BIP_RECEIVE_ID { get; set; }

        [StringLength(200)]
        public string BIP_RECEIVE_EVIDENCE_IDS { get; set; }

        public decimal? RECEIVE_STATUS { get; set; }

        public decimal? RECEIVE_EVIDENCE_STATUS { get; set; }

        public decimal? BIP_RECEIVE_CHANGE_ID { get; set; }

        [StringLength(1000)]
        public string BIP_RECEIVE_PRODUCT_IDS { get; set; }
    }
}
