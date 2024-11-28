using FitnessCenter.Core.Models;
using FitnessCenter.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenter.Data.Repositories
{
    public class GuideRepository:IGuideRepository
    {
        private readonly DataContext _context;
        public GuideRepository(DataContext context)
        {
            _context = context;
        }


        public List<Guide> GetAll()
        {
            return _context.guideList;
        }

        public Guide GetById(int id)
        {
            return _context.guideList.FirstOrDefault(g => g.ID == id);
        }

        public void PutGuide(int id, Guide g)
        {
            Guide guide = _context.guideList.FirstOrDefault(gy => gy.ID == id);
            guide.ID = g.ID;
            guide.Name = g.Name;
            guide.Domain = g.Domain;
        }

        public void PostGuide(Guide guide)
        {
            _context.guideList.Add(guide);
        }

        public void DeleteById(int id)
        {
            _context.guideList.Remove(_context.guideList.First(g => g.ID == id));
        }
    }
}
