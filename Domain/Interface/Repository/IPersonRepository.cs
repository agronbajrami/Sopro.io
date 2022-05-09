using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface.Repository
{
    public interface IPersonRepository
    {
        public Task<List<Person>> GetAll();
        public Task<Person> GetPerson(int id);
        public Task Create(Person genreClass);
    }
}
