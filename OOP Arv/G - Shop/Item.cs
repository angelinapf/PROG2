// This is a super class
public class Item
{
    // Attributes
    protected string name;
    public double value;
    public int number;

    // Constructor
    //public Item(){} // default constructor

    public Item(string name, double value, int number)
    {
        this.name = name;
        this.value = value;
        this.number = number;
    }

    // Methods
    public virtual void calcCost()
    {
        double cost = value * number;
        Console.WriteLine($"The cost of {this.name} is {cost}");
    }
}
