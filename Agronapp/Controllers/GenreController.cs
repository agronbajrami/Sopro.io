using Domain.Interface.Service;
using Domain.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AgronApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class GenreController : ControllerBase
    {
        private readonly IGenreService _genreService;
        public GenreController(IGenreService genreService)
        {
            _genreService = genreService;
        }
        // GET: api/<GenreController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
           var result = await _genreService.GetAll();
            return Ok(result);
        }

        // GET api/<GenreController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _genreService.GetGenre(id);
            if(result == null)  return NotFound("NotFound");
            return Ok(result);
        }

        // POST api/<GenreController>
        [HttpPost]
   
        public async Task<IActionResult> Post([FromBody] GenreModel genreModel)
        {
            await _genreService.Create(genreModel);
            return Ok();
        }
    }
}
