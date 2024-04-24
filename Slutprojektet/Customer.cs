#nullable disable

using System.IO;

public class Customer : Person{
    // Attributes


    // Constructor
    public Customer(string name, int age) : base(name, age){
    }

    // Methods
    public override void personMenu(){
        while (true)
        {
            DisplayInfo();
            Console.WriteLine("CUSTOMER Menu:\n");
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

    public override void DisplayInfo()
    {
        Console.WriteLine($"Hello Customer {Name}, Age: {Age}!");
    }
    
}

#nullable enable
