using Platzi_OOP_CSharp.Models;

SuperHero superHero = new SuperHero("  Bruce Wayne  ", "Batman", 38, "Gotham", "CEO", 136987159);
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

AntiHero wolverine = new AntiHero("Logan", "Wolverine", 45, "Unknown", "Unemployed", 790213);

Console.WriteLine(superHero.UseSuperPowers());
Console.WriteLine(superHero.BasicInformation);
Console.WriteLine(wolverine.DoesAntiHeroStuff("smoking a cigar"));

Console.WriteLine(wolverine.SaveTheDay());
Console.WriteLine(wolverine.SaveTheEarth());