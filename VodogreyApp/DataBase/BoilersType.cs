namespace VodogreyApp.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BoilersType")]
    public partial class BoilersType
    {
        [Key]
        public int IDB { get; set; }

        [Required]
        [StringLength(100)]
        public string TitleB { get; set; }
    }
}
