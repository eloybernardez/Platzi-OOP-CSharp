namespace Platzi_OOP_CSharp.Models
{
    internal class AntiHero : SuperHero // Herencia
    {
        public AntiHero(string name, string heroName, int age, string city, string job, int personalCard) : base(name, heroName, age, city, job, personalCard)
        {
        }

        public string DoesAntiHeroStuff(string action)
        {
            return $"{HeroName} is {action}";
        }
    }
}
