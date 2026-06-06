using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetMatcher.Api.Data;
using PetMatcher.Api.Models;

namespace PetMatcher.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PetsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        // Inject your database context
        public PetsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/pets
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pet>>> GetPets()
        {
            // This fetches all pets from the database
            var pets = await _context.Pets.ToListAsync();
            return Ok(pets);
        }
    }
}