namespace Platzi_OOP_CSharp.Models
{
    public class SuperHero
    {
        private string _Nombre;
        public int Id = 1;
        public string Nombre
        {
            get
            {
                return _Nombre;
            }
            set
            {
                _Nombre = value.Trim();
            }
        }
        public string IdentidadSecreta;
        public string Ciudad;
        public List<SuperPower> SuperPowers = new List<SuperPower>();

        public SuperHero(string nombre, string identidadSecreta, string ciudad)
        {
            Nombre = nombre;
            IdentidadSecreta = identidadSecreta;
            Ciudad = ciudad;
        }
    }
}
