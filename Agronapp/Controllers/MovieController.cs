using Domain.Interface.Service;
using Domain.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AgronApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;
        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }
        // GET: api/<MovieController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _movieService.GetAllMovies();
            return Ok(result);
        }

        // GET api/<MovieController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _movieService.GetMovieById(id);
            return Ok(result);
        }

        // POST api/<MovieController>
        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] MovieModel movieModel)
        {
            await _movieService.Create(movieModel);
            return Ok();
        }

        // PUT api/<MovieController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody]MovieModel movieModel)
        {
            await _movieService.Update(id, movieModel);
            return Ok();
        }

        // DELETE api/<MovieController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _movieService.DeleteMovie(id);
            return Ok();
        }
    }
}
