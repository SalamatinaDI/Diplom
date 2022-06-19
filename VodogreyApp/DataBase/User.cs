namespace VodogreyApp.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Users")]
    public partial class User
    {
        public int ID { get; set; }

        [StringLength(45)]
        public string Login { get; set; }

        [StringLength(45)]
        public string Pass { get; set; }
    }
}
