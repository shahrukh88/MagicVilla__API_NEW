using Magic_VillaAPI.Models;
using Magic_VillaAPI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Magic_VillaAPI.Data
{
    public class ApplicationDbContext:IdentityDbContext<ApplicationUser>
    {
                public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
                {

                }

        
        public DbSet<ApplicationUser>ApplicationUsers { get; set; }
        public DbSet<LocalUser> LocalUsers { get; set; }
        public DbSet<Villa>Villas { get; set; }
        public DbSet<VillaNumber> VillaNumbers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
                {
                       base.OnModelCreating(modelBuilder);
                       modelBuilder.Entity<Villa>().HasData(
                        new Villa()
                        {
                            Id = 1,
                            Name = "Royal Villa",
                            Details = "royal shah rukh khan for only bro chill:",
                            ImageUrl = "https://images.pexels.com/photos/414612/pexels-photo-414612.jpeg?cs=srgb&dl=pexels-james-wheeler-414612.jpg&fm=jpg",
                            Occupancy = 5,
                            Rate = 5,
                            Sqft = 5,
                            Amenity = "",
                            CreatedDate = DateTime.Now
                        });
                }
            }
}
