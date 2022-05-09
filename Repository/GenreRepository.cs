using Domain.Entities;
using Domain.Interface.Repository;
using Repository.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class GenreRepository: IGenreRepository
    {
        private readonly MovieAppDbContext _context;
        public GenreRepository(MovieAppDbContext context)
        {
            _context = context;
        }
        public async Task<GenreClass> GetGenre(int id)
        {
            var temp = _context.Genres.FirstOrDefault(g => g.Id == id);
            return temp;
        }
        public async Task<List<GenreClass>> GetAll()
        {
            var temp = _context.Genres.ToList();
            return temp;
        }

        public async Task Create(GenreClass genreClass)
        {
            await _context.Genres.AddAsync(genreClass);
            await _context.SaveChangesAsync();
        }
    }
}
