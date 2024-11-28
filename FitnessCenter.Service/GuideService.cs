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
        private readonly IGuideRepository _guideService;

        public GuideService(IGuideRepository guideService)
        {
            _guideService = guideService;
        }

        public void DeleteById(int id)
        {
            _guideService.DeleteById(id);
        }

        public List<Guide> GetAll()
        {
            return _guideService.GetAll();
        }

        public Guide GetById(int id)
        {
            return _guideService.GetById(id);
        }

        public void PostGuide(Guide guide)
        {
            _guideService.PostGuide(guide);
        }

        public void PutGuide(int id, Guide g)
        {
            _guideService.PutGuide(id, g);
        }
    }
}
