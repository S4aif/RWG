using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RWG.Models;

namespace RWG.Context
{
	public class DatabaseContext : IdentityDbContext<User>
	{

        // DbSet represents a collection of entities in the database for Users
        public DbSet<User> Users { get; set; }

        // DbSet represents a collection of entities in the database for Workouts
        public DbSet<Workout> Workouts { get; set; }

        // DbSet represents a collection of entities in the database for Exercises
        public DbSet<Exercise> Exercises { get; set; }

        // DbSet represents a collection of entities in the database for Progress
        public DbSet<Progress> Progresses { get; set; }

        // DbSet represents a collection of entities in the database for Injuries
        public DbSet<Injury> Injuries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var folder = Environment.SpecialFolder.Desktop;
            var path = Environment.GetFolderPath(folder);
            var dbPath = System.IO.Path.Join(path, "database.db");
            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }

    }
}

