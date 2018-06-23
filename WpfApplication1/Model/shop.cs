namespace WpfApplication1.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class shop : DbContext
    {
        public shop()
            : base("name=shop")
        {
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Entity1Set> Entity1Set { get; set; }
        public virtual DbSet<Entity2Set> Entity2Set { get; set; }
        public virtual DbSet<MyCategory> MyCategory { get; set; }
        public virtual DbSet<MyPersone> MyPersone { get; set; }
        public virtual DbSet<newEquipment> newEquipment { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Table_Customer> Table_Customer { get; set; }
        public virtual DbSet<TableCity> TableCity { get; set; }
        public virtual DbSet<TableEquipmentHistory> TableEquipmentHistory { get; set; }
        public virtual DbSet<TableEvaluationPriority> TableEvaluationPriority { get; set; }
        public virtual DbSet<TableEvaluationSysStatus> TableEvaluationSysStatus { get; set; }
        public virtual DbSet<TableExchangeRate> TableExchangeRate { get; set; }
        public virtual DbSet<TablesCurrency> TablesCurrency { get; set; }
        public virtual DbSet<TablesManufacturer> TablesManufacturer { get; set; }
        public virtual DbSet<TablesModel> TablesModel { get; set; }
        public virtual DbSet<TablesStopReason> TablesStopReason { get; set; }
        public virtual DbSet<TableUsers> TableUsers { get; set; }
        public virtual DbSet<TrackEvaluation> TrackEvaluation { get; set; }
        public virtual DbSet<TrackEvaluationPart> TrackEvaluationPart { get; set; }
        public virtual DbSet<TrackMeter> TrackMeter { get; set; }
        public virtual DbSet<UserHistory> UserHistory { get; set; }
        public virtual DbSet<UserMDSet> UserMDSet { get; set; }
        public virtual DbSet<UserMFSet> UserMFSet { get; set; }
        public virtual DbSet<Vacancyes> Vacancyes { get; set; }
        public virtual DbSet<dan_TablesManufacturer> dan_TablesManufacturer { get; set; }
        public virtual DbSet<dan_TablesModel> dan_TablesModel { get; set; }
        public virtual DbSet<dan_TablesStopReason> dan_TablesStopReason { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(e => e.Vacancyes)
                .WithOptional(e => e.Category)
                .HasForeignKey(e => e.CatID);

            modelBuilder.Entity<MyCategory>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<MyCategory>()
                .Property(e => e.URLmYCATEGORY)
                .IsUnicode(false);

            modelBuilder.Entity<MyPersone>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<MyPersone>()
                .Property(e => e.url)
                .IsUnicode(false);

            modelBuilder.Entity<MyPersone>()
                .Property(e => e.Portfolya)
                .IsUnicode(false);

            modelBuilder.Entity<MyPersone>()
                .Property(e => e.mail)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.User_NameEn)
                .IsFixedLength();

            modelBuilder.Entity<Table_Customer>()
                .HasMany(e => e.Order)
                .WithOptional(e => e.Table_Customer)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<TableEvaluationPriority>()
                .HasMany(e => e.TrackEvaluation)
                .WithOptional(e => e.TableEvaluationPriority)
                .HasForeignKey(e => e.intPriority);

            modelBuilder.Entity<TablesManufacturer>()
                .HasMany(e => e.newEquipment)
                .WithRequired(e => e.TablesManufacturer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TablesModel>()
                .HasMany(e => e.newEquipment)
                .WithRequired(e => e.TablesModel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<dan_TablesManufacturer>()
                .Property(e => e.strNameManuf)
                .IsUnicode(false);

            modelBuilder.Entity<dan_TablesModel>()
                .Property(e => e.strName)
                .IsUnicode(false);

            modelBuilder.Entity<dan_TablesModel>()
                .Property(e => e.strImage)
                .IsUnicode(false);

            modelBuilder.Entity<dan_TablesStopReason>()
                .Property(e => e.strReason)
                .IsUnicode(false);
        }
    }
}
