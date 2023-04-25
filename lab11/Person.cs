using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    class Person : IComparable<Person>
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        private char gender;
        public char Gender
        {
            get { return gender; }
            set { if (value == 'M' | value == 'F') gender = value; }
        }
        public Person()
        {

        }
        public override string ToString()
        {
            return Name + " " + Surname + " " + BirthDate + " " + gender;
        }
        public void Print()
        {
            Console.WriteLine($"Name: {Name} \t Surname: {Surname} \t Age: {Age(BirthDate)} \t Gender: {gender}");
        }
        public void Read()
        {
            Console.WriteLine("Input Name: ");
            Name = Console.ReadLine();

            Console.WriteLine("Input Surname: ");
            Surname = Console.ReadLine();

            Console.WriteLine("Input date of birth (yyyy-mm-dd): ");
            BirthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter gender (M/F): ");
            Gender = char.Parse(Console.ReadLine());
        }
        public int Age()
        {
            int a = DateTime.Today.Year - BirthDate.Year;
            if (BirthDate.Month > DateTime.Today.Month || (BirthDate.Month == DateTime.Today.Month && BirthDate.Day > DateTime.Today.Day))
                a--;
            return a;
        }

        public int CompareTo(Person? other)
        {
            return this.Name.CompareTo(other.Name);
        }

        public class PersonAgeComparator : IComparer<Person>
        {
            public int Compare(Person? x, Person? y)
            {
                return x.Age() - y.Age();
            }
        }
        public class PersonGenderComparator : IComparer<Person>
        {
            public int Compare(Person? x, Person? y)
            {
                return x.Gender.CompareTo(y.Gender);
            }
        }
    }
}