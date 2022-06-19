namespace VodogreyApp.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TowelDryers")]
    public partial class TowelDryer
    {
        [Key]
        public int IDT { get; set; }

        [Required]
        [StringLength(100)]
        public string TitleT { get; set; }

        public byte[] ImageT { get; set; }

        public decimal CostT { get; set; }

        [Required]
        [StringLength(10)]
        public string ArticleNumberT { get; set; }

        [StringLength(1073741823)]
        public string DescriptionT { get; set; }
    }
}
