using Apttus.Assignment.MovieTicket.Enum;

namespace Apttus.Assignment.MovieTicket
{
    public class Person : IPerson
    {
        public Person(string _name, int age, Gender Gender)
        {
            Name = _name;
            Age = age;
            gender = Gender;
        }
        public Person() { }
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender gender { get; set; }
    }
}
