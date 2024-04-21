using System;

namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();

            cat.Name = "Mesi";
            cat.Age = 1;

            Console.WriteLine(cat.Name);
            Console.WriteLine(cat.Age);

            Dog dog = new Dog();

            dog.Name = "Lili";
            dog.Age = 2;

            Console.WriteLine(dog.Name);
            Console.WriteLine(dog.Age);

            cat.MakeSound();
            dog.MakeSound();



        }
    }
}
