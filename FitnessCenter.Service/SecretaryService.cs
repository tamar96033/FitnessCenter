using FitnessCenter.Core.Models;
using FitnessCenter.Core.Repositories;
using FitnessCenter.Core.Services;
//using FitnessCenter.Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessCenter.Core.DTO;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace FitnessCenter.Service
{
    public class SecretaryService : ISecretaryService
    {
        //private readonly ISecretaryRepository _secretaryService;
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public SecretaryService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public IEnumerable<Secretary> GetAll()
        {
            return _repositoryManager.Secretaries.GetAll();
        }

        public Secretary GetById(int id)
        {
            return _repositoryManager.Secretaries.GetById(id);
        }

        public void PutSecretary(int id, Secretary s)
        {
            _repositoryManager.Secretaries.Update(s);
        }

        public void PostSecretary(SecretaryPostDTO secretary)
        {
            var secMap = _mapper.Map<Secretary>(secretary);
            var res = _repositoryManager.Secretaries.Add(secMap);

        }

        public void DeleteById(int id)
        {
            _repositoryManager.Secretaries.Delete(id);
        }
    }
}