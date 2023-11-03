namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.BIP_RECEIVE_PRODUCT")]
    public partial class BIP_RECEIVE_PRODUCT
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal? MIDDLE_TYPE { get; set; }

        public decimal? BIP_RECEIVE_ID { get; set; }

        public decimal? SALES_CONTRACT_ID { get; set; }

        public decimal? COMPANY_ID { get; set; }

        public decimal? FC_TYPE { get; set; }

        public decimal? AMOUNT { get; set; }

        public decimal? NO_RATE_AMOUNT { get; set; }

        public decimal? RATE { get; set; }

        public decimal? RATE_AMOUNT { get; set; }

        public decimal? BIP_RECEIVE_EVIDENCE_ID_RATE { get; set; }

        public decimal? BIP_RECEIVE_EVIDENCE_ID_MONTH { get; set; }

        public decimal? BIP_RECEIVE_ID_RATE { get; set; }

        public decimal? BIP_RECEIVE_ID_MONTH { get; set; }
    }
}
