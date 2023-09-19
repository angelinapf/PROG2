public class BankMain
{
    static void Main(string[] args)
    {
        Account acc1 = new Account(1, 10);
        Account acc2 = new Account(2, 14);
        Customer cust = new Customer(1, "Pelle", acc2)

        acc2.changeSum(acc1.sum/2);
        acc1.sum /= 2;

        Console.WriteLine($"Account 1 sum is {acc1.sum}");
        Console.WriteLine($"Account 2 sum is {acc2.sum}");


    }
}
