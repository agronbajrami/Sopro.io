using Domain.Entities;
using Domain.Interface.Repository;
using Domain.Model;
using Repository.DataContext;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class MovieRepository :IMovieRepository
    {

        private readonly MovieAppDbContext _context;
        public MovieRepository(MovieAppDbContext context)
        {
            _context = context;
        }
        public async Task Create(Movie movieModel)
        {
            await _context.Movies.AddAsync(movieModel);
            await _context.SaveChangesAsync();
        }
        public async Task<List<Movie>> GetAllMovies()
        {
            var result = _context.Movies.Include(t => t.Genre).Include(t => t.Person)
                .Select(
                s => new Movie
                {
                    Id = s.Id,
                    Genre = s.Genre,
                    Person = s.Person,
                    Name = s.Name,
                    Description = s.Description,
                    LengthInMin = s.LengthInMin,
                    ReleaseTime = s.ReleaseTime
                }).ToList();
           return result;
        }
        public async Task<Movie> GetMovieById(int id)
        {
            var result = _context.Movies.Include(t => t.Genre).Include(t => t.Person).Where(t => t.Id == id).Select(
               s => new Movie
               {
                   Id = s.Id,
                   Genre = s.Genre,
                   Person = s.Person,
                   Name = s.Name,
                   Description = s.Description,
                   LengthInMin = s.LengthInMin,
                   ReleaseTime = s.ReleaseTime
               }).FirstOrDefault();
            return result;
        }

        public async Task Update(int id, Movie movie)
        {
            movie.Id = id;
            _context.Movies.Update(movie);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteMovie(int id)
        {
            var result = _context.Movies.FirstOrDefault(t => t.Id == id);  
            _context.Movies.Remove(result);
            await _context.SaveChangesAsync();
        }

        
    }
}
