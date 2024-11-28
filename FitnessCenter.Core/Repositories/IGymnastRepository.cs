﻿using FitnessCenter.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenter.Core.Repositories
{
    public interface IGymnastRepository
    {
        List<Gymnast> GetAll();

        Gymnast GetById(int id);

        void PutGymnast(int id, Gymnast s);

        void PostGymnast(Gymnast gymnast);

        void DeleteById(int id);
    }
}