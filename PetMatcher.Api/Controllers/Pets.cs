using Microsoft.AspNetCore.Mvc;
using PetMatcher.Api.Models;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PetMatcher.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetMatcher : ControllerBase
    {
        // GET: api/GetAllPets
        [HttpGet(Name = "GetAllPets")]
        public IEnumerable<string> Get()
        {
            return new string[] { "Dog", "Cat", "Lizard", "Snake" };
        }

        // GET api/<ValuesController>/5
        [HttpGet("{pet}")]
        public string Get(Models.Pet PetModel)
        {
            return PetModel.Name + PetModel.Species;
        }

        // POST api/
        [HttpPost]
        public void Post([FromBody] string value)
        {
            //TODO: Some logic to find local stores that sell this type of pet
        }


        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            //TODO: Update pet model
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            //TODO: Delete specific model
        }
    }
}
