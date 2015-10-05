namespace ex2__
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GContext : DbContext
    {
        public GContext()
            : base("name=GContext")
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<BodyMeasurement> BodyMeasurements { get; set; }
        public virtual DbSet<Coach> Coaches { get; set; }
        public virtual DbSet<Dietician> Dieticians { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<MedCondition> MedConditions { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TrainingSession> TrainingSessions { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserInfo> UserInfoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Coach>()
                .HasMany(e => e.TrainingSessions)
                .WithRequired(e => e.Coach)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.BodyMeasurements)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.ClientId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.MedConditions)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.ClientId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.TrainingSessions)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserInfo>()
                .HasMany(e => e.Admins)
                .WithRequired(e => e.UserInfo)
                .HasForeignKey(e => e.InfoId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserInfo>()
                .HasMany(e => e.Coaches)
                .WithRequired(e => e.UserInfo)
                .HasForeignKey(e => e.InfoId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserInfo>()
                .HasMany(e => e.Dieticians)
                .WithRequired(e => e.UserInfo)
                .HasForeignKey(e => e.InfoId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserInfo>()
                .HasMany(e => e.Doctors)
                .WithRequired(e => e.UserInfo)
                .HasForeignKey(e => e.InfoId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserInfo>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.UserInfo)
                .HasForeignKey(e => e.InfoId)
                .WillCascadeOnDelete(false);
        }
    }
}
