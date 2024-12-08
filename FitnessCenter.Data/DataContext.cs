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
        public List<Secretary> secretaryList { get; set; }
        public List<Gymnast> gymnastList { get; set; }
        public List<Guide> guideList { get; set; }
 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=sample_db");
        }
    }
}
