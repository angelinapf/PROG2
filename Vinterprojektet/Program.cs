namespace Vinterprojektet;
class Program
{
    static void Main(string[] args)
    {

        // Create the
        Library library = new Library();
        Admin admin = new Admin(library);
        Borrower borrower = new Borrower(library);

        // Loop the Login 'menu'
        while (true)
        {
            Console.WriteLine("Login\n");
            Console.WriteLine("1. Admin");
            Console.WriteLine("2. Borrower");
            Console.WriteLine("3. Exit");

            Console.Write("write the number of your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    admin.AdminMenu();
                    break;
                case 2:
                    borrower.BorrowerMenu();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
