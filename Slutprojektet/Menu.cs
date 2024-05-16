#nullable disable

public class Menu : Storage
{
    // Attributes
    public int itemID; // ID for each menu item, ex. ID 1 = Tea etc etc
    public string itemName = ""; // name for each menu item

    // Constructor
    public Menu(){

    }

    // Methods
    public void ShowMenu()
    { // method for showing the menu
        Console.WriteLine("Menu:");
        List<string> availableItems = GetAvailableItems(); // Get available items from storage class method

        if (availableItems.Count == 0)
        {
            Console.WriteLine("There are no items available on the menu right now.");
        }
        else
        {
            foreach (string itemName in availableItems)
            {
                Console.WriteLine(itemName);
            }
        }

    }
}