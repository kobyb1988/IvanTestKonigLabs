using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using ex2_1.Models;

namespace ex2_1.DAL
{
    public class GContext : DbContext
    {
        public GContext() : base("GContext")
        {
        }

        public DbSet<UserInfo> UserInfos { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Coach> Coaches { get; set; }
        public DbSet<Dietician> Dieticians { get; set; }
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<MedCondition> MedConditions { get; set; }
        public DbSet<BodyMeasurement> BodyMeasurements { get; set; }
        public DbSet<TrainingSession> TrainingSessions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}