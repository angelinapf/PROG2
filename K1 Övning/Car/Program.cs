namespace CarProgram;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Car carlos = new Car(1, "Volvo", "Yusuf", 20000);
        carlos.speedUp(30);
        carlos.slowDown(30);
        carlos.stop();
        Console.WriteLine($"The car id is: {carlos.getId()}");
        Console.WriteLine($"The car brand is: {carlos.getBrand()}");
        Console.WriteLine($"The car speed is: {carlos.getSpeed()}");
        Console.WriteLine($"The car milage is: {carlos.getMilage()}");
        Console.WriteLine($"The car owner is: {carlos.getOwner()}");
        carlos.setOwner("Felicia");
        Console.WriteLine($"The new car owner is: {carlos.getOwner()}");
        Console.WriteLine($"The car value is: {carlos.getValue()}");
    }
}
