﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Job.Data.Models.Domain;

namespace Job.Data.Repository
{
    public class JobContext: DbContext
    {
        public JobContext() : base("JobContext")
        {
            Database.SetInitializer(new JobInitialiser());
        }
        public DbSet<App_User> AppUsers { get; set; }
        public DbSet<Employer> Employers { get; set; }
        public DbSet<AppliedJobs> AppliedJobs { get; set; }
        public DbSet<SavedJobs> SavedJobs { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Music> Musics { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
    }
}
