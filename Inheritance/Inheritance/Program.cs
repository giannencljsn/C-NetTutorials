using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Dogs dogs = new Dogs();
            Birds birds = new Birds();
            //Dogs inheriting from Animals class example
            Console.WriteLine(dogs.AnimalName);
            //Birds inheriting from Dogs class example
           Console.WriteLine(birds.dogName);


            
        }
    }

    class Animal
    {
        public string AnimalName = "Sample Animal Name";
        public DateTime AnimalBirthDate;

       public void FeedAnimal()
        {

        }

        public void SayHi()
        {
            Console.WriteLine(AnimalName);
        }

    }

    class Dogs : Animal
    {
        public string dogBreed;
        public string dogName = "Sample Dog Name";
        public bool EasyToTrain;

        public void SayHi()
        {
            Console.WriteLine(dogName);
        }
    }

    class Birds : Dogs
    {
        public string birdName;
        public string birdCountry;
        public string birdColor;

    }
}
