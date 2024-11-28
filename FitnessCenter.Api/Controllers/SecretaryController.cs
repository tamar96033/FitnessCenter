using FitnessCenter.Core.Models;
using FitnessCenter.Core.Services;
using FitnessCenter.Service;
using Microsoft.AspNetCore.Mvc;

namespace FitnessCenter.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecretaryController : Controller
    {

        private readonly ISecretaryService _secretaryService;

        public SecretaryController(ISecretaryService secretaryService)
        {
            _secretaryService = secretaryService;
        }


        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_secretaryService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(_secretaryService.GetById(id));
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Secretary s)
        {
            _secretaryService.PutSecretary(id, s);
        }

        [HttpPost]
        public void Post([FromBody] Secretary secretary)
        {
            _secretaryService.PostSecretary(secretary);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _secretaryService.DeleteById(id);
        }
    }
}
