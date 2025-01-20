using FitnessCenter.Core.Models;
using FitnessCenter.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenter.Data.Repositories
{
    public class GymnastRepository:IGymnastRepository
    {
        private readonly DataContext _context;
        public GymnastRepository(DataContext context)
        {
            _context = context;
        }



        public DbSet<Gymnast> GetAll()
        {
            return _context.gymnastList;
        }

        public Gymnast GetById(int id)
        {
            return _context.gymnastList.First(g => g.ID == id);
        }

        public void PutGymnast(int id, Gymnast g)
        {
            Gymnast gymnast = _context.gymnastList.First(gy => gy.ID == id);
            gymnast.ID = g.ID;
            gymnast.Name = g.Name;
        }
        
        public void PostGymnast(Gymnast gymnast)
        {
            _context.gymnastList.Add(gymnast);
        }

        public void DeleteById(int id)
        {

            _context.gymnastList.Remove(_context.gymnastList.First(g => g.ID == id));
        }
    }
}
