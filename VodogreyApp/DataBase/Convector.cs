namespace VodogreyApp.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Convectors")]
    public partial class Convector
    {
        [Key]
        public int IDC { get; set; }

        [Required]
        [StringLength(100)]
        public string TitleC { get; set; }

        public int? ConvectorsTypeIDC { get; set; }

        public byte[] ImageC { get; set; }

        public decimal CostC { get; set; }

        [Required]
        [StringLength(10)]
        public string ArticleNumderC { get; set; }

        [StringLength(1073741823)]
        public string DescriptionC { get; set; }
    }
}
