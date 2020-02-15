using System;

namespace Dog
{

    public enum Gender
    {
        Male,
        Female

    }
    class Dog
    {
        public static string name;
        public static string owner;
        public static int age;
        public static Gender _gender;
        public Dog(string dogname, string ownername, int dogage, Gender gender)
        {
            name = dogname;
            owner = ownername;
            age = dogage;
            _gender = gender;
        }
        public void Bark(int x)
        {
            int i = 1;
            while (i<=x)
            {
                Console.Write("Woof!");
                i++;
            }
        }
        public bool GetTag()
        {
            string sex;
            string gender;
            string year = "years";
            if(Dog._gender == 0)
            {
                sex = "His";
                gender = "he";
            }
            else
            {
                sex = "Her";
                gender = "she";
            }
            if(Dog.age == 1)
            {
                year = "year";
            }
            Console.WriteLine($"\nIf lost, call {Dog.owner}.  {sex} name is {Dog.name} and {gender} is {Dog.age} {year} old.");
            return true;
        }
    }
}
