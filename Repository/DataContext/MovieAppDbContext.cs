using Domain.Entities;
using Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Repository.DataContext
{
    public class MovieAppDbContext : DbContext
    {
        public MovieAppDbContext(DbContextOptions<MovieAppDbContext> options)
            :base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; } = null!;
        public DbSet<GenreClass> Genres { get; set; } = null!;
        public DbSet<Person> Person { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }

}
