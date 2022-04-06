using System;
using System.Collections.Generic;
using System.IO;

namespace FileInteraction
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = {"Hi", "Hello there!","How's it going?"};
            string path = @".\TestFile.txt";
            
            if(!File.Exists(path))
            {
                File.WriteAllLines(path, text);
            }
            else
            {
                File.AppendAllLines(path, text);
            }

            string[] readText = File.ReadAllLines(path);
            foreach(string s in readText)
            {
                Console.WriteLine(s);
            }

            Person SillyGuy = new Person("Zhixin", 65.4, 21);

            Console.WriteLine(SillyGuy.name);
            Console.WriteLine("SillyGuy is " + SillyGuy.age + " years old.");
            Console.WriteLine("SillyGuy is Growing up so he is now " + SillyGuy.GrowUp() + " years old.");
            Console.WriteLine("SillyGuy is " + SillyGuy.age + " years old.");
        }

    }

    class Person
    {
        public string name;
        public double height;
        public int age;


        //This is a constuctor and it is a method used to initialize an instance of the class
        public Person(string PersonName, double PersonHeight, int PersonAge) 
        {
            this.name = PersonName;
            this.height = PersonHeight;
            this.age = PersonAge;
        }

        public int GrowUp() 
        {
            this.age++;
            return this.age;
        }
    }
}