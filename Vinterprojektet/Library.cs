public class Library
{
    // Attributes
    private List<Book> books; // make a list for books

    // Constructor
    public Library()
    {
        books = new List<Book>();
    }

    // Methods
    public void AddBook(string title, string author) // Add books
    {
        Book newBook = new Book(title, author);
        books.Add(newBook);
        Console.WriteLine("Book added successfully!");
    }

    public void DisplayBooks() // Show the books (if available)
    {
        if (books.Count == 0)
        {
            Console.WriteLine("No books available in the library.");
            return;
        }

        Console.WriteLine("Books available in the library:");
        foreach (var book in books)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Available: {(book.IsAvailable ? "Yes" : "No")}");
        }
    }

    public bool LoanBook(string title) // Loan books
    {
        Book book = books.Find(b => b.Title == title && b.IsAvailable); // check if
        if (book != null)
        {
            book.IsAvailable = false;
            Console.WriteLine($"Book '{title}' loaned successfully!");
            return true;
        }
        else
        {
            Console.WriteLine($"Book '{title}' is not available for loan.");
            return false;
        }
    }

    public bool ReturnBook(string title)
    {
        Book book = books.Find(b => b.Title == title && !b.IsAvailable);
        if (book != null)
        {
            book.IsAvailable = true;
            Console.WriteLine($"Book '{title}' returned successfully!");
            return true;
        }
        else
        {
            Console.WriteLine($"Book '{title}' was not loaned out or does not exist.");
            return false;
        }
    }

    public bool DeleteBook(string title)
    {
        Book bookToRemove = books.Find(b => b.Title == title);
        if (bookToRemove != null)
        {
            books.Remove(bookToRemove);
            Console.WriteLine($"Book '{title}' removed successfully!");
            return true;
        }
        else
        {
            Console.WriteLine($"Book '{title}' does not exist.");
            return false;
        }
    }
}