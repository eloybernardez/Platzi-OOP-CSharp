using System.Text;

namespace Platzi_OOP_CSharp.Models
{
    public class SuperHero
    {
        private string _Name;
        public int Id = 1;
        // Encapsulamiento:
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value.Trim();
            }
        }
        public string NameAndSecretIdentity
        {
            get
            {
                return $"{Name} ({SecretIdentity})";
            }
        }
        private string SecretIdentity;
        public string City;
        public List<SuperPower> SuperPowers = new List<SuperPower>();

        public SuperHero(string name, string secretIdentity, string city)
        {
            Name = name;
            SecretIdentity = secretIdentity;
            City = city;
        }

        public string UseSuperPowers()
        {
            StringBuilder sb = new StringBuilder();
            foreach (SuperPower superPower in SuperPowers)
            {
                sb.AppendLine($"{NameAndSecretIdentity} is using {superPower.Name}");
            }

            return sb.ToString();
        }
    }
}
