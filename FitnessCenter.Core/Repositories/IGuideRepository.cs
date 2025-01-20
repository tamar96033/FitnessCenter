using FitnessCenter.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenter.Core.Repositories
{
    public interface IGuideRepository
    {
        DbSet<Guide> GetAll();

        Guide GetById(int id);

        void PutGuide(int id, Guide g);

        void PostGuide(Guide guide);

        void DeleteById(int id);
    }
}
