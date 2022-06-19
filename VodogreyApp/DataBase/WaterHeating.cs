namespace VodogreyApp.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WaterHeating")]
    public partial class WaterHeating
    {
        [Key]
        public int IDW { get; set; }

        [Required]
        [StringLength(100)]
        public string TitleW { get; set; }

        public int? WaterHeatingTypeIDW { get; set; }

        public byte[] ImageW { get; set; }

        public decimal CostW { get; set; }

        [Required]
        [StringLength(10)]
        public string ArticleNumberW { get; set; }

        [StringLength(1073741823)]
        public string DescriptionW { get; set; }
    }
}
