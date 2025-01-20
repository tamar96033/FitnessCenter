using FitnessCenter.Core.Models;
using FitnessCenter.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenter.Data.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly DataContext _context;
        public IRepository<Secretary> Secretaries { get; }
        public IRepository<Gymnast> Gymnasts { get; }
        public IRepository<Guide> Guides { get; }

        public RepositoryManager(DataContext context, IRepository<Secretary> secretaryRepository,
                         IRepository<Gymnast> gymnastRepository, IRepository<Guide> guideRepository)
        {
            _context = context;
            Secretaries = secretaryRepository;
            Gymnasts = gymnastRepository;
            Guides = guideRepository;
        }

        void IRepositoryManager.save()
        {
            _context.SaveChanges();
        }
    }
}

