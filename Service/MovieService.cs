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
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IGenreRepository _genreRepository;
        private readonly IPersonRepository _personRepository;
        private readonly IMapper _mapper;
        public MovieService(IMovieRepository movieRepository, IMapper mapper , IGenreRepository genreRepository, IPersonRepository personRepository)
        {
            _movieRepository = movieRepository;
            _mapper = mapper;
            _genreRepository = genreRepository;
            _personRepository = personRepository;
        }
        public async Task Create(MovieModel movieModel)
        {
            var mappedMovie = new Movie()
            {
                Description = movieModel.Description,
                LengthInMin = movieModel.LengthInMin,
                Name = movieModel.Name,
                ReleaseTime = movieModel.ReleaseTime
            };
            mappedMovie.Genre = new List<GenreClass>();
            mappedMovie.Person = new List<Person>();
            foreach (var temp in movieModel.GenreClass)
            {
                    GenreClass temp1 = await _genreRepository.GetGenre(temp);
                     mappedMovie.Genre.Add(temp1);
            }
            foreach(var temp in movieModel.Person)
            {
                Person temp1 = await _personRepository.GetPerson(temp);
                mappedMovie.Person.Add(temp1);
            }
            await _movieRepository.Create(mappedMovie);
        }
        public async Task<List<Movie>> GetAllMovies()
        {
            var result = await _movieRepository.GetAllMovies();
            return result;
        }
        public async Task<Movie> GetMovieById(int id)
        {
            var result =await _movieRepository.GetMovieById(id);
            return result;
        }

        public async Task Update(int id, MovieModel movieModel)
        {
            var mappedMovie = new Movie()
            {
                Description = movieModel.Description,
                LengthInMin = movieModel.LengthInMin,
                Name = movieModel.Name,
                ReleaseTime = movieModel.ReleaseTime
            };
            mappedMovie.Genre = new List<GenreClass>();
            mappedMovie.Person = new List<Person>();
            foreach (var temp in movieModel.GenreClass)
            {
                GenreClass temp1 = await _genreRepository.GetGenre(temp);
                mappedMovie.Genre.Add(temp1);
            }
            foreach (var temp in movieModel.Person)
            {
                Person temp1 = await _personRepository.GetPerson(temp);
                mappedMovie.Person.Add(temp1);
            }
            await _movieRepository.Update(id, mappedMovie);
        }  
        
        public async Task DeleteMovie(int id)
        {
            await _movieRepository.DeleteMovie(id);
        }
    }
}
