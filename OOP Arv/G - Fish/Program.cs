namespace Inheritance;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Fish aFish = new Fish("Green");

        Console.WriteLine("The fish is " + aFish.colour);

        Shark myShark = new Shark("eggs");
        myShark.addAge();
        System.Console.WriteLine("The shark eats " + myShark.diet + " and is age " + myShark.age);
    }
}
