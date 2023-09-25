Player thePlayer = new Player();
Goomba theGoomba = new Goomba(95, 3, "Goomba");


Console.WriteLine($"{thePlayer.name} has {thePlayer.health} healths");
Console.WriteLine($"{theGoomba.name} has {theGoomba.health} health and {theGoomba.size} size");

Console.WriteLine("Attack!");
theGoomba.health -= 10;

Console.WriteLine($"{theGoomba.name} now has {theGoomba.health} health");

Console.WriteLine("Press any key to continue...");
Console.ReadKey();

// Food fight / cooking fight

Random generator = new Random();

while (true)
{
    Console.WriteLine("Cooking fight!\n Write y to get graded on your food.");
    string answer = Console.ReadLine();

    if (answer == "y" || answer == "Y")
    {3
        int grade = generator.Next();
        if (grade > 4)
        {
            theGoomba.health -= 20;
            Console.WriteLine($"Your dish was so good, {theGoomba.name} fell down a flight of stairs. {theGoomba.name} now has {theGoomba.health} health");
            break;
        }
        else if (grade < 4)
        {
            thePlayer.health -= 20;
            Console.WriteLine($"Your dish was so bad, you fell down a flight of stairs. You now have {thePlayer.health} health");
            break;
        }
    }

}