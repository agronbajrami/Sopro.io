using Domain.Entities;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface.Service
{
    public interface IGenreService
    {
        public Task<List<GenreClass>> GetAll();
        public Task Create(GenreModel genreModel);
        public Task<GenreClass> GetGenre(int id);
    }
}
