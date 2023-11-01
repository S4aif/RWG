using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RWG.Models;

namespace RWG.Context
{
	public class DatabaseContext : IdentityDbContext<User>
	{

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var folder = Environment.SpecialFolder.Desktop;
            var path = Environment.GetFolderPath(folder);
            var dbPath = System.IO.Path.Join(path, "database.db");
            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }

    }
}

