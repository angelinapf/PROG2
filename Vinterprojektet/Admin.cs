public class Admin
{
    //Attributes
    private Library library;

    //Constructor
    public Admin(Library library)
    {
        this.library = library;
    }

    // Methods
    public void AdminMenu()
    {
        while (true)
        {
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Delete Book");
            Console.WriteLine("3. Logout");

            Console.Write("Write the number of your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Book Title: ");
                    string title = Console.ReadLine();
                    Console.Write("Enter Book Author: ");
                    string author = Console.ReadLine();
                    library.AddBook(title, author);
                    break;
                case 2:
                    Console.Write("Enter Book Title to delete: ");
                    string deleteTitle = Console.ReadLine();
                    library.DeleteBook(deleteTitle);
                    break;
                case 3:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}