using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class TicketSeller
    {
        // Input Fields
        private String name;
        private double price =100.0;
        private int numOfAdults;
        private int numOfChildren;

        // Output Fields
        private double amountToPay;

        // Read input from the user
        public void ReadInput()
        {
            Console.WriteLine("Your name please: ");
            name = Console.ReadLine();
            Console.WriteLine("Number of adults: ");
            numOfAdults = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number of children: ");
            numOfChildren = Convert.ToInt32(Console.ReadLine());
        }

        // Calculate the amount to pay
        public void CalculateAmountToPay()
        {
            amountToPay = numOfAdults * price + numOfChildren * price * 0.25;
        }

        // Print the results to the console
        public void ShowResults()
        {
            Console.WriteLine();
            Console.WriteLine("+++ Your receipt +++");
            Console.WriteLine($"+++ Amount to pay: {this.amountToPay}");
            Console.WriteLine($"+++ Price per ticket: {this.price}");
            Console.WriteLine();
            Console.WriteLine($"+++ Thank you {this.name} and please come back! +++");

        }

        // Create the start method
        public void Start()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to KIDS' FAIR!");
            Console.WriteLine("Children get always a 75% discount!");
            Console.WriteLine();
            ReadInput();
            CalculateAmountToPay();
            ShowResults();
        }   
    }
}
