// Restaurang? Café
// 
using System.IO;

namespace Slutprojektet;
class Program
{
    static void Main(string[] args)
    {
        // Create the o

        Person person = new Person();
        Worker worker = new Worker();
        Customer customer = new Customer();

        
        // The "login" (the user decides whether they are a worker or a customer)
        while (true) // while loop for the
        {
            Console.WriteLine("Café\n");
            Console.WriteLine("1. Worker");
            Console.WriteLine("2. Customer");
            Console.WriteLine("3. Exit");
            Console.Write("\nEnter your choice:");
            string choice = Console.ReadLine();

            switch (choice){
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

                break;
            }
        }
        

        
    }
}
