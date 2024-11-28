using FitnessCenter.Core.Models;
using FitnessCenter.Core.Services;
using FitnessCenter.Service;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FitnessCenter.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]

    public class GuideController : Controller
    {
        private readonly IGuideService _guideService;

        public GuideController(IGuideService guideService)
        {
            _guideService = guideService;
        }


        [HttpGet]
        public IEnumerable<Guide> Get()
        {
            return _guideService.GetAll();
        }

        [HttpGet("{id}")]
        public Guide Get(int id)
        {
            return _guideService.GetById(id);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Guide g)
        {
            _guideService.PutGuide(id, g);
        }

        [HttpPost]
        public void Post([FromBody] Guide guide)
        {
            _guideService.PostGuide(guide);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _guideService.DeleteById(id);
        }

    }

}
