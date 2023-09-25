public class BankMain
{
    static void Main(string[] args)
    {
        Account acc1 = new Account(1, 10);
        Account acc2 = new Account(2, 14);

        acc2.changeSum(acc1.getSum()/2);

        acc1.setSum(acc1.getSum()/2);


        Console.WriteLine($"Account 1 sum is {acc1.getSum()}");
        Console.WriteLine($"Account 2 sum is {acc2.getSum()}");

        Customer cust = new Customer(1, "Pelle", acc2);

        Console.WriteLine($"Account 1 sum is {acc1.getSum()} and has owner {acc1.getManager()}");
        Console.WriteLine($"Account 2 sum is {acc2.getSum()}");

    }
}
