namespace G___Shop;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Shop!");
        Item myItem = new Item("Apple", 10, 4);
        //WeightedItem wItem = new WeightedItem("Candy", 129, 30, 5); // weight in grams
        Item wItem = new WeightedItem("Candy", 129, 30, 5); // weight in grams
        
        
        myItem.calcCost();
        wItem.calcCost();
    }
}
