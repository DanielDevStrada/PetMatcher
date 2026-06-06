using Microsoft.EntityFrameworkCore;
using PetMatcher.Api.Models; 

namespace PetMatcher.Api.Data; 

public class ApplicationDbContext : DbContext
{
	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
		: base(options)
	{
	}

	public DbSet<Pet> Pets { get; set; }

    // Override OnModelCreating to add your seed data
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // This tells EF Core to insert this list of pets into the database
        modelBuilder.Entity<Pet>().HasData(PetSeedData.GetMockPets());
    }
}