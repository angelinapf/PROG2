using System.IO;

public class Storage : Café
{
    // Attributes
    private List<string> availableItems = new List<string>(); // list to store available items, for the worker to be able to add and remove items

    // Constructor

    // Methods
    public void AddToStorage(string itemName)
    {
        availableItems.Add(itemName); // add the item to the list of available items
    }

    public void RemoveFromStorage(string itemName)
    {
        availableItems.Remove(itemName); // remove the item from the list of available items
    }

    public List<string> GetAvailableItems()
    {
        return availableItems;
    }

}