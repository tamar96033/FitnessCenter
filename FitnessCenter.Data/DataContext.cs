using FitnessCenter.Core.DTO;
using FitnessCenter.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenter.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Secretary> secretaryList { get; set; }
        public DbSet<Gymnast> gymnastList { get; set; }
        public DbSet<Guide> guideList { get; set; }
 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=sample_db");
        }
    }
}
