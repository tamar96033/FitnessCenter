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
        private readonly IGymnastRepository _gymnastService;

        public GymnastService(IGymnastRepository gymnastService)
        {
            _gymnastService = gymnastService;
        }


        public List<Gymnast> GetAll()
        {
            return _gymnastService.GetAll();
        }

        public Gymnast GetById(int id)
        {
            return _gymnastService.GetById(id);
        }

        public void PostGymnast(Gymnast gymnast)
        {
            _gymnastService.PostGymnast(gymnast);
        }

        public void PutGymnast(int id, Gymnast s)
        {
            _gymnastService.PutGymnast(id, s);
        }


        public void DeleteById(int id)
        {
            _gymnastService.DeleteById(id);
        }

    }
}
