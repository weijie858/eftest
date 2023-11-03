namespace ConsoleApp_eftest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERP.FC_RECEIVE_PAYMENT_DETAILS")]
    public partial class FC_RECEIVE_PAYMENT_DETAILS
    {
        public decimal ID { get; set; }

        public decimal? MAINTABLE_ID { get; set; }

        public decimal REC_DELETED { get; set; }

        public decimal? REC_CREATOR { get; set; }

        public DateTime? REC_CREATE_DATE { get; set; }

        public decimal? REC_MODIFIER { get; set; }

        public decimal? REC_VERSION { get; set; }

        public decimal? CUSTOMER_ID { get; set; }

        public decimal? MANAGER_ID { get; set; }

        public decimal? AMOUNT_TOTAL { get; set; }

        public decimal? AMOUNT_RECEIVED { get; set; }

        public decimal? AMOUNT_RECEIVE { get; set; }

        public decimal? AMOUNT_NOTRECEIVE { get; set; }

        public decimal? TICKET_ID { get; set; }

        public decimal? AREA_MANAGER_ID { get; set; }

        public decimal? DEPT_ID { get; set; }

        public decimal? CENTER_ID { get; set; }

        public decimal? CATEGORY_ID { get; set; }

        public DateTime? REC_MODIFY_DATE { get; set; }

        public decimal? PROJECTID { get; set; }

        public decimal? STATUS { get; set; }

        [StringLength(50)]
        public string AREA_MANAGER_NAME { get; set; }

        [StringLength(100)]
        public string DEPT_NAME { get; set; }

        [StringLength(100)]
        public string CENTER_NAME { get; set; }

        [StringLength(50)]
        public string TICKET { get; set; }

        [StringLength(1000)]
        public string REMARK { get; set; }

        public decimal? PRODUCT_ID { get; set; }

        [StringLength(800)]
        public string PRODUCT_NAME { get; set; }
    }
}
