using Domain.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table("Movie")]
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseTime { get; set; }
        public double LengthInMin { get; set; }
        public virtual ICollection<GenreClass> Genre { get; set; }
        public virtual ICollection<Person> Person { get; set; }
    }
}
