using System.Collections.Generic;
using PetMatcher.Api.Models;

namespace PetMatcher.Api.Data
{
    public static class PetSeedData
    {
        public static List<Pet> GetMockPets()
        {
            return new List<Pet>
            {
                new Pet
                {
                    Id = 1,
                    Name = "Max",
                    Species = "Dog",
                    Breed = "Golden Retriever",
                    Age = 3,
                    Color = "Golden",
                    WeightInLbs = 65.4,
                    IsVaccinated = true,
                    Personality = "Friendly, energetic, and highly social"
                },
                new Pet
                {
                    Id = 2,
                    Name = "Luna",
                    Species = "Cat",
                    Breed = "Siamese",
                    Age = 2,
                    Color = "Seal Point",
                    WeightInLbs = 8.5,
                    IsVaccinated = true,
                    Personality = "Vocal, affectionate, and demanding of attention"
                },
                new Pet
                {
                    Id = 3,
                    Name = "Charlie",
                    Species = "Dog",
                    Breed = "French Bulldog",
                    Age = 1,
                    Color = "Brindle",
                    WeightInLbs = 22.1,
                    IsVaccinated = true,
                    Personality = "Playful couch potato, loves naps and treats"
                },
                new Pet
                {
                    Id = 4,
                    Name = "Bella",
                    Species = "Dog",
                    Breed = "Labrador Retriever",
                    Age = 5,
                    Color = "Black",
                    WeightInLbs = 72.0,
                    IsVaccinated = true,
                    Personality = "Loyal, gentle, and excellent swimmers"
                },
                new Pet
                {
                    Id = 5,
                    Name = "Oliver",
                    Species = "Cat",
                    Breed = "Domestic Shorthair",
                    Age = 4,
                    Color = "Tabby",
                    WeightInLbs = 11.2,
                    IsVaccinated = true,
                    Personality = "Calm, independent, but loves a good chin scratch"
                },
                new Pet
                {
                    Id = 6,
                    Name = "Milo",
                    Species = "Cat",
                    Breed = "Bengal",
                    Age = 1,
                    Color = "Spotted Rosette",
                    WeightInLbs = 10.6,
                    IsVaccinated = false,
                    Personality = "High energy, highly intelligent, and loves water"
                },
                new Pet
                {
                    Id = 7,
                    Name = "Daisy",
                    Species = "Dog",
                    Breed = "Beagle",
                    Age = 2,
                    Color = "Tricolor",
                    WeightInLbs = 24.5,
                    IsVaccinated = true,
                    Personality = "Curious, driven by scent, and very vocal"
                },
                new Pet
                {
                    Id = 8,
                    Name = "Rocky",
                    Species = "Dog",
                    Breed = "German Shepherd",
                    Age = 4,
                    Color = "Black and Tan",
                    WeightInLbs = 83.1,
                    IsVaccinated = true,
                    Personality = "Protective, disciplined, and quick to learn"
                },
                new Pet
                {
                    Id = 9,
                    Name = "Cleo",
                    Species = "Cat",
                    Breed = "Persian",
                    Age = 7,
                    Color = "White",
                    WeightInLbs = 9.0,
                    IsVaccinated = true,
                    Personality = "Quiet, dignified, and prefers a peaceful home"
                },
                new Pet
                {
                    Id = 10,
                    Name = "Coco",
                    Species = "Dog",
                    Breed = "Chihuahua",
                    Age = 6,
                    Color = "Fawn",
                    WeightInLbs = 5.3,
                    IsVaccinated = true,
                    Personality = "Feisty, fiercely loyal to one person, alert"
                }
            };
        }
    }
}