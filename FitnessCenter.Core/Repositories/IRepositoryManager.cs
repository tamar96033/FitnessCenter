using FitnessCenter.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenter.Core.Repositories
{
    public interface IRepositoryManager
    {
        public IRepository<Secretary> Secretaries { get; }
        public IRepository<Gymnast> Gymnasts { get; }
        public IRepository<Guide> Guides { get; }

        public void save();
    }
}
