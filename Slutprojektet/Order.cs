#nullable disable

using System.IO;

public class Order{
    // Attributes
    public int OrderNumber; // the number for the order, so the system can organize different orders
    // public Customer Customer;
    public List<Menu> items; // a list of items that are eventually gonna be ordered and implemented into the order

    
    public Order(int orderNumber){
        OrderNumber = orderNumber; 

        string[] orderContent = {"", "", ""};

        File.WriteAllLines(@"receipt.txt", orderContent);
    }

    // Methods
    public void listOrders(){

    }


}

#nullable enable