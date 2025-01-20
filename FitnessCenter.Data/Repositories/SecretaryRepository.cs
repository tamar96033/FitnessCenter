using FitnessCenter.Core.DTO;
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
    public class SecretaryRepository : ISecretaryRepository
    {
        private readonly DataContext _context;
        public SecretaryRepository(DataContext context)
        {
            _context = context;
        }

        public DbSet<Secretary> GetAll()
        {
            return _context.secretaryList;
        }

        public Secretary GetById(int id)
        {
            return _context.secretaryList.FirstOrDefault(g => g.ID == id);
        }

        public void PutSecretary(int id, Secretary s)
        {
            Secretary secretary = _context.secretaryList.FirstOrDefault(gy => gy.ID == id);
            secretary.ID = s.ID;
            secretary.Name = s.Name;
        }

        public void PostSecretary(SecretaryPostDTO secretary)
        {
            Random rand = new Random();
            Secretary sec = new Secretary() { ID = rand.Next(0, 100), Name = secretary.Name };
            _context.secretaryList.Add(sec);
        }

        public void DeleteById(int id)
        {
            _context.secretaryList.Remove(_context.secretaryList.First(s => s.ID == id));
        }

    }
}
