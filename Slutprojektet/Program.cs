#nullable disable
// Restaurang? Café
// 
using System.IO;
namespace Slutprojektet;
class Program
{
    static void Main(string[] args)
    {
        string nameInput = "";
        int ageInput = 0;

        while (true)
        {
            Console.Write("What is your name?: ");
            nameInput = Console.ReadLine();

            Console.Write("How old are you?: ");
            if (int.TryParse(Console.ReadLine(), out ageInput))
            {
                // Age input is valid, break out of the loop
                break;
            }
            else
            {
                Console.WriteLine("Invalid age. Please enter a valid number.");
            }
        }

        Storage storage = new Storage();
        Menu menu = new Menu();
        Order order = new Order();
        Worker worker = new Worker(nameInput, ageInput, storage);
        Customer customer = new Customer(nameInput, ageInput);

        // The "login" (the user decides whether they are a worker or a customer)
        while (true) // while loop for the
        {
            Console.WriteLine("Café\n");
            Console.WriteLine("1. Worker");
            Console.WriteLine("2. Customer");
            Console.WriteLine("3. Exit");
            Console.Write("\nEnter your choice:");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Clear();
                    worker.personMenu();

                    break;
                case "2":
                    Console.Clear();
                    customer.personMenu();

                    break;
                case "3":
                    Console.Clear();
                    Environment.Exit(0);

                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");

                    break;
            }
        }



    }
}

#nullable enable 
