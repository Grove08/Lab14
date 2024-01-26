using System;

namespace Lab14
{
    abstract class Animal
    {
        public abstract string Name { get; }

        public Animal()
        {
            
        }

        public abstract void Say();

        public void ShowInfo()
        {
            Console.WriteLine($"Название: {Name}");
            Say();
        }
    }

    class Cat : Animal
    {
        public override string Name => "Кошка";

        public override void Say()
        {
            Console.WriteLine("Мяу");
        }
    }
    class Dog : Animal
    {
        public override string Name => "Собака";

        public override void Say()
        {
            Console.WriteLine("Гав");
        }
    }
}
