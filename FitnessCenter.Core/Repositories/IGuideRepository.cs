using FitnessCenter.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenter.Core.Repositories
{
    public interface IGuideRepository
    {
        List<Guide> GetAll();

        Guide GetById(int id);

        void PutGuide(int id, Guide g);

        void PostGuide(Guide guide);

        void DeleteById(int id);
    }
}
