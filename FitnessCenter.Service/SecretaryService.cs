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
    public class SecretaryService : ISecretaryService
    {
        private readonly ISecretaryRepository _secretaryService;

        public SecretaryService(ISecretaryRepository secretaryService)
        {
            _secretaryService = secretaryService;
        }

        public List<Secretary> GetAll()
        {
            return _secretaryService.GetAll();
        }

        public Secretary GetById(int id)
        {
            return _secretaryService.GetById(id);
        }

        public void PutSecretary(int id, Secretary s)
        {
            _secretaryService.PutSecretary(id, s);
        }

        public void PostSecretary(Secretary secretary)
        {
            _secretaryService.PostSecretary(secretary);
        }

        public void DeleteById(int id)
        {
            _secretaryService.DeleteById(id);
        }
    }
}
