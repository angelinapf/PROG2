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

    public void SaveOrder()
    {
        using (StreamWriter writer = File.AppendText("receipt.txt"))
        {
            writer.WriteLine($"Order Number: {GenerateOrderNumber()}");
            writer.WriteLine("Items:");

            foreach (Menu item in items)
            {
                writer.WriteLine(item.itemName);
            }

            writer.WriteLine();
        }

    }

    private int GenerateOrderNumber()
    {
        return DateTime.Now.GetHashCode(); // generate a unique order number based on the current time
    }

    // Method
    public void ListOrders()
    {
        string[] orders = File.ReadAllLines("receipt.txt");
        foreach (string order in orders)
        {
            Console.WriteLine(order);
        }
    }


}

#nullable enable