using JokesOnYou.Web.Api.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JokesOnYou.Web.Api.Data
{
    public class DataContext : IdentityDbContext<User>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Tag>()
                .HasMany(t => t.Users);
        }
    
        public DbSet<SavedJoke> SavedJokes { get; set; }

        public DbSet<Joke> Jokes { get; set; }

        public DbSet<Tag> Tags { get; set; }
    }
}
