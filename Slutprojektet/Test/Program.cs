using System.IO;

namespace Test;
class Program
{
    static void Main(string[] args)
    {
        

        string[] orderContent = {"Hey", "Booo", "Wow"};

        File.WriteAllLines(@"receipt.txt", orderContent);

        string contents = File.ReadAllText(@"receipt.txt");
        Console.WriteLine(contents);
    }
}
