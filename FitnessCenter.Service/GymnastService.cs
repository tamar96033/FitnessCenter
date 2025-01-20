using FitnessCenter.Core.Models;
using FitnessCenter.Core.Repositories;
using FitnessCenter.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenter.Service
{
    public class GymnastService : IGymnastService
    {
        private readonly IRepository<Gymnast> _gymnastService;

        public GymnastService(IRepository<Gymnast> gymnastService)
        {
            _gymnastService = gymnastService;
        }


        public IEnumerable<Gymnast> GetAll()
        {
            return _gymnastService.GetAll();
        }

        public Gymnast GetById(int id)
        {
            return _gymnastService.GetById(id);
        }

        public void PostGymnast(Gymnast gymnast)
        {
            _gymnastService.Update(gymnast);
        }

        public void PutGymnast(int id, Gymnast s)
        {
            _gymnastService.Add(s);
        }


        public void DeleteById(int id)
        {
            _gymnastService.Delete(id);
        }

    }
}
