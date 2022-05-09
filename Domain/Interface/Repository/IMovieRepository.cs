using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface.Repository
{
    public interface IMovieRepository
    {
        public Task Create(Movie movieModel);
        public Task<List<Movie>> GetAllMovies();
        public Task<Movie> GetMovieById(int id);
        Task Update(int id, Movie returnMappedModel);
        Task DeleteMovie(int id);
    }
}
