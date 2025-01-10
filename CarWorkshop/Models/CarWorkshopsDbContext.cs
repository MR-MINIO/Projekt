using Microsoft.EntityFrameworkCore;
using CarWorkshop.Entities;

namespace CarWorkshop.Models
{
    public class CarWorkshopsDbContext : DbContext
    {
        public CarWorkshopsDbContext(DbContextOptions<CarWorkshopsDbContext>option) : base(option)
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
