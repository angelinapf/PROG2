public class Borrower
{
    //Attributes
    private Library library;
    public int amountBooks;

    //Constructor
    public Borrower(Library library)
    {
        this.library = library;
    }

    //Methods
    public void BorrowerMenu()
    {
        while (true)
        {
            Console.WriteLine("1. View Available Books");
            Console.WriteLine("2. Loan a Book");
            Console.WriteLine("3. Return a Book");
            Console.WriteLine("4. Logout");

            Console.Write("Write the number of your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    library.DisplayBooks();
                    break;
                case 2:
                    Console.Write("Enter Book Title to loan: ");
                    string loanTitle = Console.ReadLine();
                    library.LoanBook(loanTitle);
                    break;
                case 3:
                    Console.Write("Enter Book Title to return: ");
                    string returnTitle = Console.ReadLine();
                    library.ReturnBook(returnTitle);
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}