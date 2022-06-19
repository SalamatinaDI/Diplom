namespace VodogreyApp.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ConvectorsType")]
    public partial class ConvectorsType
    {
        [Key]
        public int IDC { get; set; }

        [Required]
        [StringLength(100)]
        public string TitleC { get; set; }
    }
}
