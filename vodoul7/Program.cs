using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul7
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public Person(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Person))
                return false;

            Person otherPerson = (Person)obj;

            return Name == otherPerson.Name && Age == otherPerson.Age && Gender == otherPerson.Gender;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ Age.GetHashCode() ^ Gender.GetHashCode();
        }

        public static bool operator ==(Person person1, Person person2)
        {
            if (ReferenceEquals(person1, null))
            {
                return ReferenceEquals(person2, null);
            }
            return person1.Equals(person2);
        }

        public static bool operator !=(Person person1, Person person2)
        {
            return !(person1 == person2);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Person person1 = new Person("John", 25, "Male");
            Person person2 = new Person("John", 25, "Male");
            Person person3 = new Person("Jane", 30, "Female");

            Console.WriteLine(person1 == person2);  // Выведет "True"
            Console.WriteLine(person1 != person3);  // Выведет "True"
            Console.WriteLine(person1.Equals(person2));  // Выведет "True"
            Console.WriteLine(person2.Equals(person3));  // Выведет "False"
        }
    }
}
