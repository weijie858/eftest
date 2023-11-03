namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PM_BORROW_PARTS_DETAIL")]
    public partial class PM_BORROW_PARTS_DETAIL
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal BORROW_PARTS_ID { get; set; }

        public DateTime BORROW_DATE { get; set; }

        public decimal BORROW_EMPLOYEE_ID { get; set; }

        public DateTime? RETURN_DATE { get; set; }

        public decimal? RETURN_NUMBER { get; set; }

        public decimal QUANTITY { get; set; }

        public decimal STATUS { get; set; }

        [StringLength(100)]
        public string REMARK { get; set; }
    }
}
