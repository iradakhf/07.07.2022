using ConsoleApp1;
using System;
namespace Program
{
    class Program
    {
        static void Main(string[] arg)
        {
            Dog dog = new Dog("labrador", "golden", 2);
            Cat cat = new Cat("anyType", "black", 1);

            Console.WriteLine(dog.name);
            Console.WriteLine(cat.color);

        }
       
        }
    }
