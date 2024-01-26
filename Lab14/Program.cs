using System;

namespace Lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat();
            cat.ShowInfo();

            Console.WriteLine();

            Animal dog = new Dog();
            dog.ShowInfo();
        }
    }
}

