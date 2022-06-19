namespace VodogreyApp.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Boilers")]
    public partial class Boiler
    {
        [Key]
        public int IDB { get; set; }

        [Required]
        [StringLength(100)]
        public string TitleB { get; set; }

        public int? BoilersTypeIDB { get; set; }

        public byte[] ImageB { get; set; }

        public decimal CostB { get; set; }

        [StringLength(10)]
        public string ArticleNumberB { get; set; }

        [StringLength(1073741823)]
        public string DescriptionB { get; set; }
    }
}
