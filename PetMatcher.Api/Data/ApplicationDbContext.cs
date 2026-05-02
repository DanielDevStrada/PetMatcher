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
}