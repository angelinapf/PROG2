#nullable disable

using System.IO;

public class Customer : Person
{
    // Attributes
    private Menu menu; // instance of menu
    private Order currentOrder; // current order for the customer

    // Constructor
    public Customer(string name, int age) : base(name, age)
    {
        currentOrder = new Order();
    }

    // Methods
    public override void personMenu()
    {
        while (true)
        {
            DisplayInfo();
            Console.WriteLine("CUSTOMER Menu:\n");
            Console.WriteLine("1: View Menu");
            Console.WriteLine("2: Order");
            Console.WriteLine("2: Complete Order");

            Console.Write("\nEnter your choice:");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Clear();
                    menu.ShowMenu();

                    break;

                case "2":
                    Console.Clear();
                    PlaceOrder();

                    break;

                case "3":
                    Console.Clear();

                    break;
            }
        }
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Hello Customer {Name}, Age: {Age}!");
    }

    private void PlaceOrder()
    {
        Console.WriteLine("Place your order (type 'done' to finish):");
        currentOrder = new Order(); // Create a new order
        string itemName;
        do
        {
            Console.Write("Item name: ");
            itemName = Console.ReadLine();
            if (itemName.ToLower() != "done")
            {
                // Add the item to the order
                Menu item = new Menu(); // Assuming ID is not used in the constructor
                currentOrder.AddItem(item);
            }
        } while (itemName.ToLower() != "done");

        // Save the order
        currentOrder.SaveOrder();
        Console.WriteLine("Order placed successfully!");
    }

}

#nullable enable
