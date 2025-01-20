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
    public class GuideService : IGuideService
    {
        private readonly IRepository<Guide> _guideService;

        public GuideService(IRepository<Guide> guideService)
        {
            _guideService = guideService;
        }

        public void DeleteById(int id)
        {
            _guideService.Delete(id);
        }

        public IEnumerable<Guide> GetAll()
        {
            return _guideService.GetAll();
        }

        public Guide GetById(int id)
        {
            return _guideService.GetById(id);
        }

        public void PostGuide(Guide guide)
        {
            _guideService.Update(guide);
        }

        public void PutGuide(int id, Guide g)
        {
            _guideService.Add(g);
        }
    }
}
