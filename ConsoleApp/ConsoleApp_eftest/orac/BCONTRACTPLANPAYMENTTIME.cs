namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.BCONTRACTPLANPAYMENTTIME")]
    public partial class BCONTRACTPLANPAYMENTTIME
    {
        [StringLength(50)]
        public string ID { get; set; }

        public decimal PLANYEAR { get; set; }

        public decimal PLANMONTH { get; set; }

        public decimal AREACODE { get; set; }

        public decimal PLANWEEKPAYMENT { get; set; }
    }
}
