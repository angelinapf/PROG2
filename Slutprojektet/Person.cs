#nullable disable

public class Person
{
    // Attributes
    private Menu menu;
    private Storage storage;
    private Order order;

    public string Name { get; set; }
    public int Age { get; set; }

    // Constructor
    public Person(string name, int age)
    {

        Name = name;
        Age = age;

    }

    // Methods
    public virtual void personMenu() { }

    public virtual void DisplayInfo()
    {

        Console.WriteLine($"Name: {Name}, Age: {Age}");

    }

}

#nullable enable