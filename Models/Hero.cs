namespace Platzi_OOP_CSharp.Models
{
    internal abstract class Hero : Person
    {
        public Hero(string name, int age, string city, string job, int personalCard) : base(name, age, city, job, personalCard)
        {
        }

        // Abstracción:
        // Con abstract se obliga a las clases que hereden de Hero a implementar el método SaveTheDay
        public abstract string SaveTheDay();
    }
}
