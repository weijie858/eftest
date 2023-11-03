namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.BIP_RECEIVE_CHANGE_DETAIL")]
    public partial class BIP_RECEIVE_CHANGE_DETAIL
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal? BIP_RECEIVE_CHANGE_ID { get; set; }

        public decimal? BIP_RECEIVE_ID { get; set; }

        public DateTime? FINISH_DATE { get; set; }

        public DateTime? CHANGE_FINISH_DATE { get; set; }
    }
}
