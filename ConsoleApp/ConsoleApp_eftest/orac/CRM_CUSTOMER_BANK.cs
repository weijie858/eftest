namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.CRM_CUSTOMER_BANK")]
    public partial class CRM_CUSTOMER_BANK
    {
        [Key]
        [Column(Order = 0)]
        public decimal ID { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal REC_DELETED { get; set; }

        public decimal? REC_CREATOR { get; set; }

        public DateTime? REC_CREATE_DATE { get; set; }

        public decimal? REC_MODIFIER { get; set; }

        public DateTime? REC_MODIFY_DATE { get; set; }

        [StringLength(50)]
        public string BANKNAME { get; set; }

        [StringLength(50)]
        public string BANKCODE { get; set; }

        [StringLength(50)]
        public string BANKNUMBER { get; set; }

        public decimal? CUSTOMERID { get; set; }

        public decimal? REC_VERSION { get; set; }

        public decimal? ORDERNO { get; set; }
    }
}
