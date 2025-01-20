using FitnessCenter.Core.DTO;
using FitnessCenter.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenter.Core.Repositories
{
    public interface ISecretaryRepository
    {
        DbSet<Secretary> GetAll();

        Secretary GetById(int id);

        void PutSecretary(int id, Secretary s);

        void PostSecretary(SecretaryPostDTO secretary);

        void DeleteById(int id);
    }
}
