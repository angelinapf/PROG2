public class Book{
    public string Title { get; set; }
    public string Author { get; set; }
    public bool IsAvailable { get; set; } = true;

    public Book(string title, string author)
    {
            Title = title;
            Author = author;
    }
}