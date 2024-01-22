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
        private double price =10.0;
        private int numOfAdults;
        private int numOfChildren;

        // Output Fields
        private double amountToPay;

        // Read input from the user
        public void ReadInput()
        {
            Console.WriteLine("Enter the name of the movie: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the number of adults: ");
            numOfAdults = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of children: ");
            numOfChildren = Convert.ToInt32(Console.ReadLine());
        }

        public void CalculateAmountToPay()
        {
            amountToPay = numOfAdults * price + numOfChildren * price * 0.25;
        }

        public void ShowResults()
        {
            Console.WriteLine();
            Console.WriteLine("+++++++++++++++++++++++++");
            Console.WriteLine($"Movie: {this.name}");
            Console.WriteLine($"Number of adults: {this.numOfAdults}");
            Console.WriteLine($"Number of children: {this.numOfChildren}");
            Console.WriteLine($"Amount to pay: {this.amountToPay}");
            Console.WriteLine("+++++++++++++++++++++++++");
        }   
        public void Start()
        {
            ReadInput();
            CalculateAmountToPay();
            ShowResults();
        }   
    }
}
