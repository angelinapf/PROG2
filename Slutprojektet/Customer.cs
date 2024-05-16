#nullable disable

using System.IO;

public class Customer : Person
{
    // Attributes
    private Menu menu; // instance of menu
    private Order currentOrder; // current order for the customer
    private Person person;

    // Constructor
    public Customer(string name, int age) : base(name, age)
    {
        currentOrder = new Order();
        menu = new Menu(); // menu object
    }

    // Methods
    public override void personMenu() // overriden method for personMenu, the customer menu
    {
        while (true)
        {
            DisplayInfo();
            Console.WriteLine("CUSTOMER Menu:\n");
            Console.WriteLine("1: View Menu");
            Console.WriteLine("2: Order");
            Console.WriteLine("3: Complete Order");
            Console.WriteLine("4: Go back to the start menu");

            Console.Write("\nEnter your choice:");
            string choice = Console.ReadLine();

            switch (choice) // depending on the users input, switch between cases
            {
                case "1":
                    Console.Clear(); // clear the console/terminal
                    menu.ShowMenu(); // show menu from menu

                    break;

                case "2":
                    Console.Clear();
                    PlaceOrder(); // run the placeorder method

                    break;

                case "3":
                    Console.Clear();

                    break;

                case "4":
                    Console.Clear();
                    person.personMenu();

                    break;

                default: // if user does not enter any of the 'available' choices, run this default case
                    Console.WriteLine("Invalid choice. Please try again.");

                    break;
            }
        }
    }

    public override void DisplayInfo() // overriden method of displayinfo, from superclass Person
    {
        Console.WriteLine($"Hello Customer {Name}, Age: {Age}!");
    }

    private void PlaceOrder()
    {
        Console.WriteLine("Place your order (type 'done' to finish):");
        currentOrder = new Order(); // create a new order
        string itemName;
        do // do while loop for the order, it will loop until user decides it's done (they write done)
        {
            Console.Write("Item name: ");
            itemName = Console.ReadLine();
            if (itemName.ToLower() != "done")
            {
                // add the item to the order
                Menu item = new Menu(); 
                currentOrder.AddItem(item);
            }
        } while (itemName.ToLower() != "done");

        // Save the order
        currentOrder.SaveOrder();
        Console.WriteLine("Order placed successfully!");
    }

}

#nullable enable
