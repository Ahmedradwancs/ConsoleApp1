using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Library
    {
        private string name;
        private string bookName;
        private int days;
        private DateTime date;

        //Read the user input
        public void ReadInput()
        {
            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the book name: ");
            bookName = Console.ReadLine();
            Console.WriteLine("For how many days you want to borrow this book? ");
            days = Convert.ToInt32(Console.ReadLine());
        }

        //Calculate the due date
        public DateTime CalculateDueDate()
                {
                    date = DateTime.Now;
                    DateTime dueDate = date.AddDays(days);
                    return dueDate;
                }

        //Display all the data
        public void Display()
        {
            Console.WriteLine("Your name is: " + name);
            Console.WriteLine($"The want to borrow {bookName} book. " );
            Console.WriteLine("The due date to return the book is: " + CalculateDueDate());
            Console.WriteLine("Thank you for using our library!");
        }
        public void Start()
        {
            Console.WriteLine("Welcome to the Library!");
            Console.WriteLine();
            Console.WriteLine("Please enter the following details: ");
            ReadInput();
            Display();
            Console.ReadLine();
        }
    }
}
