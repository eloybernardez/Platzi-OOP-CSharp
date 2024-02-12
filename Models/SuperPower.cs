namespace Platzi_OOP_CSharp.Models
{
    public class SuperPower
    {
        public int Id = 1;
        public string Name;
        public string Description;
        public PowerLevel Level;
    }

    public enum PowerLevel
    {
        Low,
        Medium,
        High
    }
}
