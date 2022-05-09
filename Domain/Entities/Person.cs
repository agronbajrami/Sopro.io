using Domain.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table("Person")]
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public UserRole UserRole { get; set; }
        public virtual ICollection<Movie> Movie { get; set; }
    }
}
