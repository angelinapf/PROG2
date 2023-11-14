public class Fish
{
    // Attributes
    public string colour;
    public string nose;
    public string climate;
    public int age;

    // Constructors
    public Fish() // default constructor
    {
        age=0;
    }

    public Fish(string colour)
    {
        this.colour = colour;
    }

    // Methods
    public void addAge()
    {
        this.age++;
    }
}
