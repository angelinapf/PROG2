#nullable disable

using System.Dynamic;
using System.IO;

public class Order
{
    // Attributes
    public List<Menu> items { get; private set; } // a list of items that are eventually gonna be ordered and implemented into the order

    // Constructor
    public Order()
    {
        items = new List<Menu>();
    }

    public void AddItem(Menu item) // method to add an item to the order
    {
        items.Add(item);
    }

    public void SaveOrder() // method to save the order to the receipt.txt file
    {
        using (StreamWriter writer = File.AppendText("receipt.txt")) // open a stream to add to the receipt.txt file
        {
            writer.WriteLine($"Order Number: {GenerateOrderNumber()}"); // write the order number
            writer.WriteLine("Items:"); // write the items

            foreach (Menu item in items)
            {
                writer.WriteLine(item.itemName);
            }

            writer.WriteLine(); // adds an empty line so its easier to read
        }

    }

    private int GenerateOrderNumber()
    {
        return DateTime.Now.GetHashCode(); // generate a unique order number based on the current time
    }

    
    public void ListOrders() // method to list all orders from the receipt.txt file
    {
        string[] orders = File.ReadAllLines("receipt.txt");
        foreach (string order in orders)
        {
            Console.WriteLine(order);
        }
    }


}

#nullable enable