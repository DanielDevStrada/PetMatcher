// Models/Pet.cs
namespace PetMatcher.Api.Models
{
    public class Pet
    {
        public int Id { get; set; } // The Primary Key

        // Basic Attributes
        public string Name { get; set; } = string.Empty;
        public string Species { get; set; } = string.Empty;
        public string Breed { get; set; } = string.Empty;
        public int Age { get; set; }

        // Example: Adding more attributes you might want to track
        public string Color { get; set; } = string.Empty;
        public double WeightInLbs { get; set; }
        public bool IsVaccinated { get; set; }
        public string Personality { get; set; } = string.Empty;
    }
}