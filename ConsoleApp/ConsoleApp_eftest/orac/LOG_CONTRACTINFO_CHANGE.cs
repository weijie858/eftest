namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.LOG_CONTRACTINFO_CHANGE")]
    public partial class LOG_CONTRACTINFO_CHANGE
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

        public decimal? PROJECT_MANAGER_ID { get; set; }

        public decimal? SALES_ID { get; set; }

        public decimal? PROJECT_MANAGER_ID_NEW { get; set; }

        public decimal? SALES_ID_NEW { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal STATUS { get; set; }

        public decimal? CM_SALES_CONTRACT_ID { get; set; }

        public decimal? MAIN_ID { get; set; }
    }
}
