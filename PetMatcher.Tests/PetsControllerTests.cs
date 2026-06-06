using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetMatcher.Api.Controllers;
using PetMatcher.Api.Data;
using PetMatcher.Api.Models;

namespace PetMatcher.Tests;

public class PetsControllerTests
{
    private ApplicationDbContext GetInMemoryDbContext()
    {
        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;

        return new ApplicationDbContext(options);
    }

    [Fact]
    public async Task GetPets_ReturnsOkResult_WithAllSeededPets()
    {
        // Arrange
        using var context = GetInMemoryDbContext();
        context.Pets.AddRange(PetSeedData.GetMockPets());
        await context.SaveChangesAsync();

        var controller = new PetsController(context);

        // Act
        var result = await controller.GetPets();

        // Assert
        var okResult = Assert.IsType<OkObjectResult>(result.Result);
        var returnedPets = Assert.IsAssignableFrom<IEnumerable<Pet>>(okResult.Value);

        Assert.True(returnedPets.Count() == 10, "Expected exactly 10 seeded pets to be returned by the database.");
        Assert.Contains(returnedPets, p => p.Name == "Max" && p.Breed == "Golden Retriever");
    }
}