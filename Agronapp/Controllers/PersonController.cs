using Domain.Interface.Service;
using Domain.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AgronApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;
        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }
        // GET: api/<PersonController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _personService.GetAll();
            return Ok(result);
        }

        // GET api/<PersonController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _personService.GetPerson(id);
            return Ok(result);
        }

        // POST api/<PersonController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PersonModel personModel)
        {
            await _personService.Create(personModel);
            return Ok();
        }
    }
}
