namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SetupConsoleWindow();
            Console.Title = "My Favourite Pet";

            // Create a Pet object
            Pet pet = new Pet();
            // Call the Start method
            pet.Start();

            Console.WriteLine("Press Enter to start next part!");
            Console.ReadLine();

            // Create a TicketSeller object
            TicketSeller ticketSeller = new TicketSeller();
            // Call the Start method of the TicketSeller object
            ticketSeller.Start();

            Console.WriteLine();
            Console.WriteLine("Press Enter to start next part!");
            Console.ReadLine();

            // Create an Album object
            Album album = new Album();
            // Call the Start method of the Album object
            album.Start();

            Console.WriteLine();
            Console.WriteLine("Press Enter to start next part!");
            Console.ReadLine();

            // Create a Library object
            Library library = new Library();
            // Call the Start method of the Library object
            library.Start();

            Console.WriteLine("Thank you for using my application.");
            Console.WriteLine();
            Console.WriteLine("Press Enter to exit the program!");
            Console.ReadLine();


        }

        static void SetupConsoleWindow()
        {
            // Arranging the console window            
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "My Console Classes";
        }
    }
}
