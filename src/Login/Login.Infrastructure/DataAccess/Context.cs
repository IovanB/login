using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Login.Infrastructure.DataAccess
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (Environment.GetEnvironmentVariable("LOGIN_CONN") != null)
            {
                optionsBuilder.UseNpgsql(Environment.GetEnvironmentVariable("LOGIN_CONN"), npgsqlOptionsAction: options =>
                {
                    options.EnableRetryOnFailure(2, TimeSpan.FromSeconds(5), new List<string>());
                    options.MigrationsHistoryTable("_MigrationHistory", "UsersRegister");
                });
            }
            else
            {
                optionsBuilder.UseInMemoryDatabase("LOGINInMemory");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
