using System.IO;

public class Worker : Person{
    // Attributes
    
    // Constructor

    // Methods
    public override void personMenu(){
        Console.WriteLine("Worker: Welcome!\n");
        Console.WriteLine("1: Look through Orders");
        Console.WriteLine("2: Print Receipt");
        Console.WriteLine("3: Add items to menu");
        Console.WriteLine("4: Remove items from menu");

        Console.Write("\nEnter your choice:");
        string choice = Console.ReadLine();

        switch (choice){
            case "1": // if the user enters choice number 1 (i.e. input is 1), this choice will run
                Console.Clear();
                

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


            break;

            case "4": // if the user enters choice number 4 (i.e. input is 4), this choice will run
                Console.Clear();

            break;
        }
    }
}