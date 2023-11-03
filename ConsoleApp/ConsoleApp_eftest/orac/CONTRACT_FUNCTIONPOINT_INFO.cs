namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.CONTRACT_FUNCTIONPOINT_INFO")]
    public partial class CONTRACT_FUNCTIONPOINT_INFO
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

        [Key]
        [Column(Order = 7)]
        public decimal SALE_CONTRACT_ID { get; set; }

        [StringLength(500)]
        public string SON_SYSTEM { get; set; }

        [StringLength(500)]
        public string FIRST_MODULE { get; set; }

        [StringLength(500)]
        public string POINT_NAME { get; set; }

        [StringLength(50)]
        public string TYPE { get; set; }

        public decimal? UFP { get; set; }

        [StringLength(50)]
        public string REUSABILITY { get; set; }

        [StringLength(50)]
        public string CHANGE_POINT { get; set; }

        public decimal? US_INFO { get; set; }

        [StringLength(500)]
        public string REMARK_INFO { get; set; }

        public decimal? SOFTCHANGE_ID { get; set; }

        public decimal? POINT_ID { get; set; }

        public decimal? FROM_TYPE { get; set; }

        public decimal? POINT_TYPE { get; set; }

        public decimal? STATUS { get; set; }

        public decimal? ORDERNO { get; set; }
    }
}
