namespace EFTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Drawing;

    [Table("ProductInfo")]
    class ProductInfo
    {
        [Key, Required, MaxLength(50)]
        public string PSN { get; set; }

        [MaxLength(50)]
        public string T1Data { get; set; }

        public bool T1Result { get; set; }

        [MaxLength(50)]
        public string T2Data { get; set; }

        public bool T2Result { get; set; }

        [MaxLength(50)]
        public string T3Data { get; set; }

        public bool T3Result { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

    }
}
