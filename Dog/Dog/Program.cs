using System;

namespace Dog
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog puppy = new Dog("Orian", "Shawn", 1, Gender.Male);
            puppy.Bark(3);
            puppy.GetTag();

            Dog myDog = new Dog("Lileu", "Dale", 4, Gender.Female);
            myDog.Bark(1);
            myDog.GetTag();
        }
    }
}
