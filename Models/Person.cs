namespace Platzi_OOP_CSharp.Models
{
    public class Person
    {
        private string _Name;
        // Encapsulamiento:
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value?.Trim() ?? "John Doe";
            }
        }
        public int Id = 2;
        public int Age;
        public string City;
        public string Job;
        private int _IdCardNumber;
        public int PersonalCard
        {
            get
            {
                return _IdCardNumber;
            }
            set
            {
                _IdCardNumber = value == 0 ? 123456789 : value;
            }
        }
        public string BasicInformation
        {
            get
            {
                return $"{Name} ({Age}) lives in {City} and his/her first two Id Card Number are {_IdCardNumber.ToString().Substring(0, 2)}";
            }
        }

        public Person(string name, int age, string city, string job, int personalCard)
        {
            Name = name;
            Age = age;
            City = city;
            Job = job;
            PersonalCard = personalCard;
        }
    }
}
