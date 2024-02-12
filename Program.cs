using Platzi_OOP_CSharp.Models;

SuperHero superHero = new SuperHero("  Batman  ", "Bruce Wayne", "Gotham");
superHero.SuperPowers.Add(new SuperPower
{
    Name = "Wealth",
    Description = "Has a lot of money",
    Level = PowerLevel.High
});

superHero.SuperPowers.Add(new SuperPower
{
    Name = "Intelligence",
    Description = "Is very smart",
    Level = PowerLevel.High
});

Console.WriteLine(superHero.UseSuperPowers());