using Domain.Entities;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface.Service
{
    public interface IMovieService
    {
        public Task Create(MovieModel movieModel);
        public Task<List<Movie>> GetAllMovies();
        public Task<Movie> GetMovieById(int id);
        Task Update(int id, MovieModel movieModel);
        Task DeleteMovie(int id);
    }
}
