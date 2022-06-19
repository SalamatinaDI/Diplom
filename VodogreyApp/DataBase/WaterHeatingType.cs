namespace VodogreyApp.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WaterHeatingType")]
    public partial class WaterHeatingType
    {
        [Key]
        public int IDW { get; set; }

        [Required]
        [StringLength(100)]
        public string TitleW { get; set; }
    }
}
