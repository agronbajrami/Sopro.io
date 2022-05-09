using Domain.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table("GenreTable")]
    public class GenreClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Movie> Movie { get; set; }
    }
}
