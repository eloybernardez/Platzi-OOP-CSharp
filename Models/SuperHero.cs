using System.Text;

namespace Platzi_OOP_CSharp.Models
{
    public class SuperHero : Person // Herencia
    {
        public int Id = 1;
        public string HeroName;
        public string SecretIdentity
        {
            get
            {
                IEnumerable<string> arrange = Name.Split(" ").Select(s => new string(s.Reverse().ToArray()));
                string result = string.Join(" ", arrange);

                return result;
            }
        }
        public List<SuperPower> SuperPowers = new List<SuperPower>();

        public SuperHero(string name, string heroName, int age, string city, string job, int personalCard) : base(name, age, city, job, personalCard) // Polimorfismo (sobrecarga de constructores)
        {
            HeroName = heroName;
        }

        public string UseSuperPowers()
        {
            StringBuilder sb = new StringBuilder();
            foreach (SuperPower superPower in SuperPowers)
            {
                sb.AppendLine($"{HeroName} is using {superPower.Name}");
            }

            return sb.ToString();
        }
    }
}
