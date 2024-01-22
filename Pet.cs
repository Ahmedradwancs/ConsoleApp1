using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Pet
    {
        private String name;
        private int age;
        private bool isFemale;

        // Read input from the user
        public void ReadAndSavePetData()
        {
            Console.WriteLine("Enter the name of your pet: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the age of your pet: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Is your pet a female (y/n) ? ");
            if (Console.ReadLine().ToLower() == "y")
            {
                isFemale = true;
            }
            else
            {
                isFemale = false;
            }
        }

        // Print the data to the console
        public void DisplayPetInfo()
        {
            Console.WriteLine();
            Console.WriteLine("+++++++++++++++++++++++++");
            Console.WriteLine($"Name: {this.name} Age: {this.age}");
            if (this.isFemale == true)
            {
                Console.WriteLine("She's such a wonderful pup!");
            }
            else
            {
                Console.WriteLine("He's such a wonderful pup!");
            }
            Console.WriteLine("+++++++++++++++++++++++++");

        }

        // Create the start method
        public void Start()
        {
            Console.WriteLine();
            Console.WriteLine("Greetings from the pet CLass!");
            Console.WriteLine();

            ReadAndSavePetData();
            DisplayPetInfo();
        }
    }
}
