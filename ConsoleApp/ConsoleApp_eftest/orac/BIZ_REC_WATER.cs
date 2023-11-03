namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.BIZ_REC_WATER")]
    public partial class BIZ_REC_WATER
    {
        [StringLength(36)]
        public string ID { get; set; }

        [StringLength(36)]
        public string GUID { get; set; }

        public decimal? TYPE { get; set; }

        [StringLength(64)]
        public string NOTECODE { get; set; }

        [StringLength(36)]
        public string DEPTCODE { get; set; }

        [StringLength(36)]
        public string APPLYORGCODE { get; set; }

        public DateTime? PAYDATE { get; set; }

        [StringLength(50)]
        public string PAYTYPECODE { get; set; }

        [StringLength(50)]
        public string SETTLEMENTMODECODE { get; set; }

        [StringLength(50)]
        public string ORGCODE { get; set; }

        [StringLength(50)]
        public string CAPITALCATEGORYCODE { get; set; }

        [StringLength(50)]
        public string BUDGETITEMCODE { get; set; }

        public decimal? ISURGENT { get; set; }

        [StringLength(500)]
        public string PURPOSE { get; set; }

        [StringLength(50)]
        public string CHECKCODE { get; set; }

        [StringLength(500)]
        public string OFFICEPURPOSE { get; set; }

        [StringLength(500)]
        public string ABSTRACTS { get; set; }

        [StringLength(512)]
        public string MEMO { get; set; }

        [StringLength(50)]
        public string OURORGCODE { get; set; }

        [StringLength(100)]
        public string OURBANKACCOUNTNUMBER { get; set; }

        [StringLength(50)]
        public string OURCURCODE { get; set; }

        public decimal? OURAMOUNT { get; set; }

        [StringLength(250)]
        public string OPPOBJECTNAME { get; set; }

        [StringLength(50)]
        public string OPPOBJECTCODE { get; set; }

        [StringLength(50)]
        public string OPPCOUNTERPARTYCATEGORYCODE { get; set; }

        [StringLength(50)]
        public string OPPBANKCODE { get; set; }

        [StringLength(50)]
        public string OPPBANKLOCATIONCODE { get; set; }

        [StringLength(250)]
        public string OPPBANKLOCATIONS { get; set; }

        [StringLength(50)]
        public string OPPBANKACCOUNTNUMBER { get; set; }

        [StringLength(250)]
        public string OPPBANKACCOUNTNAME { get; set; }

        [StringLength(50)]
        public string OPPBANKAREACODE { get; set; }

        [StringLength(50)]
        public string OPPDIRECTCURCODE { get; set; }

        [StringLength(50)]
        public string OPPCELLPHONE { get; set; }

        public decimal? ISPAYFAILSENDMSG { get; set; }

        public decimal? OPPPRIVATEFLAG { get; set; }

        [StringLength(2)]
        public string OPPCERTTYPE { get; set; }

        [StringLength(50)]
        public string OPPCERTNUMBER { get; set; }

        [StringLength(50)]
        public string OPPEMAILADDRESS { get; set; }

        [StringLength(2)]
        public string OPPCARDTYPE { get; set; }

        [StringLength(2)]
        public string PAYSTATE { get; set; }

        [StringLength(500)]
        public string PAYINFO { get; set; }

        public DateTime? PAYMADEDATE { get; set; }

        [StringLength(100)]
        public string SRCSERIALNO { get; set; }

        [StringLength(100)]
        public string SRCNOTECODE { get; set; }

        [StringLength(100)]
        public string CASHCODE { get; set; }

        public DateTime? CREATEDONTIME { get; set; }

        [StringLength(100)]
        public string ACCEPTANCEDRAFTCODES { get; set; }

        [StringLength(100)]
        public string OTHERCODE { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(100)]
        public string CASHFLOW { get; set; }

        [StringLength(200)]
        public string TYPEFLOW { get; set; }

        [StringLength(50)]
        public string PROJECTCODE { get; set; }

        [StringLength(500)]
        public string PROJECTNAME { get; set; }

        [StringLength(100)]
        public string CASHFLOWNAME { get; set; }

        [StringLength(100)]
        public string TYPEFLOWNAME { get; set; }

        [StringLength(50)]
        public string CONTRACTNO { get; set; }

        [StringLength(150)]
        public string CONTRACTNAME { get; set; }

        [StringLength(50)]
        public string CONTRACTTYPE { get; set; }

        [StringLength(50)]
        public string CONTRCTCOMPANYCODE { get; set; }

        [StringLength(50)]
        public string CONTRCTCOMPANYNAME { get; set; }

        [StringLength(50)]
        public string SONCONTRCTCOMPANYCODE { get; set; }

        [StringLength(50)]
        public string SONCONTRCTCOMPANYNAME { get; set; }

        [StringLength(50)]
        public string SONPEOPLE { get; set; }

        public decimal? CONTRACTAMOUNT { get; set; }

        public decimal? CONTRACTRECIVE { get; set; }

        public decimal? ISMODIFY { get; set; }

        [StringLength(50)]
        public string ERPUPDATER { get; set; }

        public DateTime? ERPUPDATE { get; set; }

        [StringLength(50)]
        public string ERPUPDATERIDCARD { get; set; }

        [StringLength(50)]
        public string SUREFROM { get; set; }

        [StringLength(50)]
        public string ERPCONTRACTNO { get; set; }

        public decimal? DIVIDEDTAG { get; set; }

        public decimal? ASSIGNED_COMPANYID { get; set; }
    }
}
