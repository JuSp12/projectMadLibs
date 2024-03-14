using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            This program Mad Libs
            Author: JS
            */


            // Let the user know that the program is starting:

            Console.WriteLine("Mad Libs has started!");

            // Give the Mad Lib a title:
            string title = "One little story";

            Console.WriteLine(title);
            // Define user input and variables:
            Console.WriteLine("Enter a name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter adjective 1: ");
            string adjective1 = Console.ReadLine();
            Console.WriteLine("Enter adjective 2 ");
            string adjective2 = Console.ReadLine();
            Console.WriteLine("Enter adjective 3 ");
            string adjective3 = Console.ReadLine();
            Console.WriteLine("Enter verb ");
            string verb = Console.ReadLine();
            Console.WriteLine("Enter nouns 1 ");
            string nouns1 = Console.ReadLine();
            Console.WriteLine("Enter nouns 2 ");
            string nouns2 = Console.ReadLine();

            Console.WriteLine("Enter an animal ");
            string animal = Console.ReadLine();
            Console.WriteLine("Enter food ");
            string food = Console.ReadLine();
            Console.WriteLine("Enter nouns 2 ");
            string fruit = Console.ReadLine();
            Console.WriteLine("Enter fruit ");
            string superhero = Console.ReadLine();
            Console.WriteLine("Enter country ");
            string country = Console.ReadLine(); 
            Console.WriteLine("Enter dessert ");
            string dessert = Console.ReadLine();
            Console.WriteLine("Enter year ");
            string year = Console.ReadLine();


            // The template for the story:

            string story = $"This morning {name} woke up feeling {adjective1}. 'It is going to be a {adjective2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {nouns1}, which made all the {fruit}s very {adjective3}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {nouns2}s ruled the world.";


            // Print the story:
            Console.WriteLine(story);

        }
    }
}
