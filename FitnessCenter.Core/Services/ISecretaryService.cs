﻿using FitnessCenter.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenter.Core.Services
{
    public interface ISecretaryService
    {
        List<Secretary> GetAll();

        Secretary GetById(int id);

        void PutSecretary(int id, Secretary s);

        void PostSecretary(Secretary secretary);

        void DeleteById(int id);
    }
}
