using Microsoft.EntityFrameworkCore;

namespace ChefsNDishes.Models
{
    public class ChefContext : DbContext
    {
        public ChefContext(DbContextOptions options) : base(options) { }

        // for every model / entity that is going to be part of the db
        // the names of these properties will be the names of the tables in the db
        public DbSet<Chef> chefs { get; set; }
        public DbSet<Dish> dishes { get; set; }
    }
}