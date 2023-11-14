// This is a sub class
public class WeightedItem : Item{
    // Attributes
    double weight;

    // Constructor
    public WeightedItem(String name, double value, int number, double weight) : base(name, value, number){
        
        this.weight = weight;
    }

    // Methods
    public override void calcCost(){
        double cost = value*number*(weight/1000);
        Console.WriteLine($"The cost of {this.name} is {cost}");
    }
}