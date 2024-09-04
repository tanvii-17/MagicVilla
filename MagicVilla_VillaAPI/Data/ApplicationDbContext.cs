using MagicVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa() { 
                    Id = 1,
                    Name = "Royal Villa",
                    Details = "hello to new villa",
                    ImageUrl = "",
                    Occupancy = 3,
                    Sqft = 400,
                    Rate = 500,
                    Amenity = "",
                    CreatedDate = DateTime.Now
                });
        }
    }
}
