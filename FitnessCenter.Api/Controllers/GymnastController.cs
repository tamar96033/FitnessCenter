using FitnessCenter.Core.Models;
using FitnessCenter.Core.Services;
using FitnessCenter.Service;
using Microsoft.AspNetCore.Mvc;

namespace FitnessCenter.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GymnastController : Controller
    {
        private readonly IGymnastService _gymnastService;

        public GymnastController(IGymnastService gymnastService)
        {
            _gymnastService = gymnastService;
        }

        // GET: GymnastController
        [HttpGet]
        public IEnumerable<Gymnast> Get()
        {
            return _gymnastService.GetAll();
        }

        [HttpGet("{id}")]
        public Gymnast Get(int id)
        {
            return _gymnastService.GetById(id);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Gymnast g)
        {
            _gymnastService.PutGymnast(id, g);
        }

        [HttpPost]
        public void Post([FromBody] Gymnast gymnast)
        {
            _gymnastService.PostGymnast(gymnast);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _gymnastService.DeleteById(id);
        }


    }
}
