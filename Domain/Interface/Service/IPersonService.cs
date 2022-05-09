using Domain.Entities;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface.Service
{
    public interface IPersonService
    {
        public Task<List<Person>> GetAll();
        public Task<Person> GetPerson(int id);
        public Task Create(PersonModel genreModel);
    }
}
