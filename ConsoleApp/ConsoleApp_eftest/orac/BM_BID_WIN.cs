namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.BM_BID_WIN")]
    public partial class BM_BID_WIN
    {
        [Key]
        [Column(Order = 0)]
        public decimal ID { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal REC_DELETED { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal REC_CREATOR { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime REC_CREATE_DATE { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal REC_MODIFIER { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime REC_MODIFY_DATE { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal REC_VERSION { get; set; }

        [StringLength(300)]
        public string BID_WIN_NO { get; set; }

        [StringLength(300)]
        public string PROJECT_NAME { get; set; }

        public decimal? BID_WIN_AMOUNT { get; set; }

        public decimal? PRIMA_COMPANY_ID { get; set; }

        public decimal? CREATE_COMPANY_ID { get; set; }

        [StringLength(300)]
        public string BID_TYPE { get; set; }

        public DateTime? BID_WIN_DATE { get; set; }

        public decimal? BUSSINESSID { get; set; }

        [StringLength(300)]
        public string BUSSINESSER { get; set; }

        public decimal? SIGN_STATUS { get; set; }

        public decimal? CITY_ID { get; set; }

        [StringLength(300)]
        public string CITY_NAME { get; set; }

        public decimal? PROVINCE_ID { get; set; }

        [StringLength(300)]
        public string PROVINCE_NAME { get; set; }

        [StringLength(300)]
        public string BUSINESS_TYPE { get; set; }

        [StringLength(300)]
        public string BUSINESS_TYPE_NAME { get; set; }

        public decimal? BID_ENTER_AMOUNT { get; set; }

        public decimal? ENTER_STATUS { get; set; }

        [StringLength(300)]
        public string APPLICANTNO { get; set; }

        [StringLength(1000)]
        public string REMARK { get; set; }
    }
}
