using CarsWorkshop.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarsWorkshop.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public DbSet<CarWorkshopEntity> CarWorkshops { get; set; }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
}
