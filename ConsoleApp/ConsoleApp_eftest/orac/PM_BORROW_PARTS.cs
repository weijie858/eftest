namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.PM_BORROW_PARTS")]
    public partial class PM_BORROW_PARTS
    {
        public decimal ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal REC_CREATOR { get; set; }

        public DateTime REC_CREATE_DATE { get; set; }

        public decimal REC_MODIFIER { get; set; }

        public DateTime REC_MODIFY_DATE { get; set; }

        public decimal REC_VERSION { get; set; }

        public decimal? BORROW_MONTH { get; set; }

        [Required]
        [StringLength(100)]
        public string PARTS_NAME { get; set; }

        public decimal QUANTITY { get; set; }

        public decimal RECEIVER_EMPLOYEE_ID { get; set; }

        public decimal SUPPLIER_ID { get; set; }

        public decimal SUPPLIER_CONTACT_ID { get; set; }

        public decimal STATUS { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        [Required]
        [StringLength(100)]
        public string PARTS_MODEL { get; set; }

        public DateTime RECEIVER_DATE { get; set; }

        public DateTime? RETURN_DATE { get; set; }

        [StringLength(50)]
        public string RETURN_NUMBER { get; set; }
    }
}
