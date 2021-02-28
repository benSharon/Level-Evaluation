using LevelEvaluation.Data;
using System;

namespace Q2_Register
{
    class Program
    {
        /// <summary>
        /// This method prints info provided by a user about themselves.
        /// The text after * should be displayed in the console.
        /// The text surrounded by -- is an example of a user input.
        /// You must complete the todos in the Person class first.
        /// You must use the Person class with its ToString method.
        /// </summary>
        static void Main(string[] args)
        {
            var individual = new Person("John");
            Console.WriteLine(individual);
            Console.WriteLine("================================================");

            Console.Write("Hello, please enter your name: ");
            string pName = Console.ReadLine();

            Console.Write("How old are you? ");
            int pAge = int.Parse(Console.ReadLine());

            Console.Write("Where are you from? ");
            string pCountry = Console.ReadLine();

            Console.Write("What languages do you speak? ");
            string[] pLanguage = Console.ReadLine().Split();

            var otherIndividual = new Person(pName, pAge, pCountry, pLanguage);
            Console.WriteLine(otherIndividual.ToString());

            // * Hello, please enter your name: 
            // -- Max --

            // * How old are you?
            // -- 25 --

            // * Where are you from?
            // -- United States --

            // * What languages do you speak?
            // -- English French Japanese --

            // * Hey there! My name is Max.
            // * I am from the United States and I am 25 years old.
            // * I speak the following languages: English, French, Japanese.
        }
    }
}
