using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class MovieModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseTime { get; set; }
        public double LengthInMin { get; set; }
        public List<int> GenreClass { get; set; }
        public List<int> Person { get; set; }
    }
}
