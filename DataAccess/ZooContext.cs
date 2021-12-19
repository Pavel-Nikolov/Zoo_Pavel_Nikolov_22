using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    //Context class for the database
    public class ZooContext : DbContext
    {
        //The three tables in the database
        public DbSet<Mamal> Mamals { get; set; }
        public DbSet<Bird> Birds { get; set; }
        public DbSet<Reptile> Reptiles { get; set; }

        public ZooContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ZooDB;Trusted_Connection=True;MultipleActiveResultSets=true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
