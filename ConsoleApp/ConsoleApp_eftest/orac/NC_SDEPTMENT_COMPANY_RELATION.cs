namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.NC_SDEPTMENT_COMPANY_RELATION")]
    public partial class NC_SDEPTMENT_COMPANY_RELATION
    {
        [StringLength(20)]
        public string DEPTID { get; set; }

        [StringLength(40)]
        public string DEPTCODE { get; set; }

        [StringLength(300)]
        public string CDEPT { get; set; }

        [StringLength(20)]
        public string SUPDEPTID { get; set; }

        [StringLength(300)]
        public string SUPDEPTCODE { get; set; }

        [StringLength(40)]
        public string AREACODE { get; set; }

        [StringLength(3)]
        public string STATUS { get; set; }

        [StringLength(4)]
        public string DEPTKIND { get; set; }

        public decimal? ID { get; set; }

        [Key]
        public decimal COMPANY_ID { get; set; }
    }
}
