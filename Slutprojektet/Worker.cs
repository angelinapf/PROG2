#nullable disable

public class Worker : Person
{
    // Attributes
    private Storage storage; // instance of storage
    private Menu menu; // instance of menu
    private Order order; // instance of order

    // Constructor
    public Worker(string name, int age, Storage storage) : base(name, age)
    {
        this.storage = storage;
    }

    // Methods
    public override void personMenu()
    {

        DisplayInfo();
        Console.WriteLine("WORKER Menu:\n");
        Console.WriteLine("1: Look through Orders");
        Console.WriteLine("2: Print Receipt");
        Console.WriteLine("3: Add items to menu");
        Console.WriteLine("4: Remove items from menu");

        Console.Write("\nEnter your choice:");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1": // if the user enters choice number 1 (i.e. input is 1), this choice will run
                Console.Clear();
                order.ListOrders();

                break;

            case "2": // if the user enters choice number 2 (i.e. input is 2), this choice will run
                Console.Clear();

                Console.WriteLine("This is the receipt: \n");

                // Printing receipt from the order
                string receipt = File.ReadAllText(@"receipt.txt");
                Console.WriteLine(receipt);


                break;

            case "3": // if the user enters choice number 3 (i.e. input is 3), this choice will run
                Console.Clear();
                AddItemsToStorage();

                break;

            case "4": // if the user enters choice number 4 (i.e. input is 4), this choice will run
                Console.Clear();
                RemoveItemsFromStorage();
                
                break;
        }
    }

     private void AddItemsToStorage()
    {
        Console.Write("Enter the name of the item to add to storage: ");
        string itemName = Console.ReadLine();
        storage.AddToStorage(itemName);
        Console.WriteLine($"Added {itemName} to storage.");
    }

    private void RemoveItemsFromStorage()
    {
        Console.Write("Enter the name of the item to remove from storage: ");
        string itemName = Console.ReadLine();
        storage.RemoveFromStorage(itemName);
        Console.WriteLine($"Removed {itemName} from storage.");
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Hello Worker {Name}, Age: {Age}!");
    }
}

#nullable enable