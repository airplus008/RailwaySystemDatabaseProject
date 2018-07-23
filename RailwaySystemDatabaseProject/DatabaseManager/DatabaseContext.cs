using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using RailwaySystemDatabaseProject.Models;
using Oracle.ManagedDataAccess.Client;

namespace RailwaySystemDatabaseProject.DatabaseManager
{
    public class MyContext : DbContext
    {
        public DbSet<Train> Trains{ get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //配置mariadb连接字符串
            optionsBuilder.UseSqlServer(Config.ConnectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }

}
