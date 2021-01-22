using System;

namespace SOLID_Labb
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = AnimalColor();

            Console.WriteLine("###############");
            Console.WriteLine();

            Loop(animals);




        }

        static Animal[] AnimalColor()
        {
            Animal[] animals = {new Dog("Black"),
                            new Hedgehog("Pink"),
                            new Bird("Yellow")};
            return animals;
        }

        static void Loop(Animal[] animals)
        {
            foreach (var animal in animals)
            {
                if (animal is Dog dog)
                {
                    dog.TransferOwnership("Niklas");
                }
                AnimalText(animal);
            }
        }

        static void AnimalText(Animal animal)
        {
            animal.Eat();
            animal.Sleep();
            animal.Speak();
            animal._color = "Grey";
            Console.WriteLine(animal.GetType().Name + " is " + animal._color);
            Console.WriteLine();

            Console.WriteLine("###############");
            Console.WriteLine();
        }
    }
}
