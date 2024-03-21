using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person persOne = new Person();
            persOne.FirstName = "Gianne";
            persOne.LastName = "Juson";
            persOne.Country = "Switzerland";
            
            Person persTwo = new Person();

            persTwo.FirstName = "Shampoo";
            persTwo.LastName = "Bo";
            persTwo.Country = "China";

            Console.WriteLine(persOne.FirstName);
            Console.WriteLine(persTwo.FirstName);
        }
    }

    class Person
    {
        string firstName;
        string lastName;
        DateTime birthDate;
        string country;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public DateTime BirthDate { get; set; }

        public string Country { get; set; }
    }
}
