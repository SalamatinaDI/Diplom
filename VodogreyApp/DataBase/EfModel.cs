using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace VodogreyApp.DataBase
{
    public partial class EfModel : DbContext
    {
        private static EfModel Instance;
        public static EfModel Init()
        {
            if (Instance == null)
                Instance = new EfModel();
            return Instance;
        }
        public EfModel()
            : base("name=EfModel")
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Boiler> Boilers { get; set; }
        public virtual DbSet<BoilersType> BoilersTypes { get; set; }
        public virtual DbSet<Convector> Convectors { get; set; }
        public virtual DbSet<ConvectorsType> ConvectorsTypes { get; set; }
        public virtual DbSet<TowelDryer> TowelDryers { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<WaterHeating> WaterHeatings { get; set; }
        public virtual DbSet<WaterHeatingType> WaterHeatingTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>()
                .Property(e => e.Login)
                .IsUnicode(false);

            modelBuilder.Entity<Boiler>()
                .Property(e => e.TitleB)
                .IsUnicode(false);

            modelBuilder.Entity<Boiler>()
                .Property(e => e.ArticleNumberB)
                .IsUnicode(false);

            modelBuilder.Entity<Boiler>()
                .Property(e => e.DescriptionB)
                .IsUnicode(false);

            modelBuilder.Entity<BoilersType>()
                .Property(e => e.TitleB)
                .IsUnicode(false);

            modelBuilder.Entity<Convector>()
                .Property(e => e.TitleC)
                .IsUnicode(false);

            modelBuilder.Entity<Convector>()
                .Property(e => e.ArticleNumderC)
                .IsUnicode(false);

            modelBuilder.Entity<Convector>()
                .Property(e => e.DescriptionC)
                .IsUnicode(false);

            modelBuilder.Entity<ConvectorsType>()
                .Property(e => e.TitleC)
                .IsUnicode(false);

            modelBuilder.Entity<TowelDryer>()
                .Property(e => e.TitleT)
                .IsUnicode(false);

            modelBuilder.Entity<TowelDryer>()
                .Property(e => e.ArticleNumberT)
                .IsUnicode(false);

            modelBuilder.Entity<TowelDryer>()
                .Property(e => e.DescriptionT)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Login)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Pass)
                .IsUnicode(false);

            modelBuilder.Entity<WaterHeating>()
                .Property(e => e.TitleW)
                .IsUnicode(false);

            modelBuilder.Entity<WaterHeating>()
                .Property(e => e.ArticleNumberW)
                .IsUnicode(false);

            modelBuilder.Entity<WaterHeating>()
                .Property(e => e.DescriptionW)
                .IsUnicode(false);

            modelBuilder.Entity<WaterHeatingType>()
                .Property(e => e.TitleW)
                .IsUnicode(false);
        }
    }
}
