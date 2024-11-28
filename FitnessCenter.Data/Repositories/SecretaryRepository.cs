using FitnessCenter.Core.Models;
using FitnessCenter.Core.Repositories;
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

        public List<Secretary> GetAll()
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

        public void PostSecretary(Secretary secretary)
        {
            _context.secretaryList.Add(secretary);
        }

        public void DeleteById(int id)
        {
            _context.secretaryList.Remove(_context.secretaryList.First(s => s.ID == id));
        }
    }
}
