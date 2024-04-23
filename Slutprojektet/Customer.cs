using System.IO;

public class Customer : Person{
    // Attributes
    private List<Order> orders; // a list of orders 

    // Constructor
    public Customer(){
        orders = new List<Order>();
    }

    // Methods
    public override void personMenu(){
        while (true)
        {
            Console.WriteLine("Customer: Welcome!\n");
            Console.WriteLine("1: View Menu");
            Console.WriteLine("2: Order");

            Console.Write("\nEnter your choice:");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                break;

                case "2":
                break;

                case "3":
                break;
            }
        }
    }
    
}
