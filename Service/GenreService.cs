using AutoMapper;
using Domain.Entities;
using Domain.Interface.Repository;
using Domain.Interface.Service;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class GenreService : IGenreService
    {
        private readonly IGenreRepository _genreRepository;
        private readonly IMapper _mapper;
        public GenreService(IGenreRepository genreRepository, IMapper mapper)
        {
            _genreRepository = genreRepository;
            _mapper = mapper;
        }
      
        public async Task<List<GenreClass>> GetAll()
        {
            var result = await _genreRepository.GetAll();
            return result;
        }
        public async Task Create(GenreModel genreModel)
        {
            var mappedMovie = new GenreClass()
            {
                Name = genreModel.Name
            };
            await _genreRepository.Create(mappedMovie);
        }
        public async Task<GenreClass> GetGenre(int id)
        {
            var result = await _genreRepository.GetGenre(id);
            return result;
        }

    
    }
}
