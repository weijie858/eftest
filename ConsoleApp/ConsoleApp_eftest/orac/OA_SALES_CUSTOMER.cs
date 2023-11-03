namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.OA_SALES_CUSTOMER")]
    public partial class OA_SALES_CUSTOMER
    {
        [StringLength(50)]
        public string ID { get; set; }

        [StringLength(1000)]
        public string NAME { get; set; }

        [StringLength(300)]
        public string ADDRESS { get; set; }

        [StringLength(20)]
        public string INDUSTRYID { get; set; }

        public int? CITYID { get; set; }

        [StringLength(20)]
        public string COUNTRYID { get; set; }

        public int? GROUPID { get; set; }

        public int? STATUSID { get; set; }

        public byte? SORT { get; set; }

        public bool? ISACTIVE { get; set; }

        [StringLength(50)]
        public string OTHERMSG { get; set; }

        public int? CUSTOMERTYPEID { get; set; }

        [StringLength(50)]
        public string UPDATEUSERNO { get; set; }

        public int? PROVINCEID { get; set; }

        public int? REGIONID { get; set; }

        [StringLength(100)]
        public string CREATETIME { get; set; }

        [StringLength(100)]
        public string UPDATETIME { get; set; }

        public decimal? GLEVEL { get; set; }

        [StringLength(10)]
        public string PCUSTOMERID { get; set; }

        [StringLength(10)]
        public string TEL { get; set; }

        [StringLength(50)]
        public string BANK { get; set; }

        [StringLength(20)]
        public string BANKACCOUNT { get; set; }

        [StringLength(50)]
        public string TAXNUMBER { get; set; }
    }
}
