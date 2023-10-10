using System;

public class Tamagochi
{
    // Attributes
    private int hunger;
    private int boredom;
    private List<string> words = new List<string>();
    private bool isAlive;
    private Random generator = new Random();
    public string name;

    // Constructor
    public Tamagochi(int hunger, int boredom, string name)
    {
        this.hunger = hunger;
        this.boredom = boredom;
        this.name = name;
    }

    // Methods
    public void Feed(int food)
    {
        if (this.hunger - food > 0)
        {
            this.hunger = this.hunger - food;
        }
        else
        {
            Console.WriteLine("Your Tamagochi is not hungry.");
        }
    }

    public void Hi() {
        // Get random string from the list words
        int index = generator.Next(words.Count);
        string randomWord = words[index];
        Console.WriteLine(randomWord);
        ReduceBoredom();
    }

    public void Teach(string word)
    {
        words.Add(this.word);
        ReduceBoredom();
    }

    public void Tick() {
        if (hunger >= 10 || boredom >= 10)
        {
            isAlive = false;
        }
        else
        {
            hunger++;
            boredom++;
        }
    }

    public void PrintStats()
    {
        Console.WriteLine($"{name} stats\nHunger: {hunger}\nBoredom: {boredom}\nTamagochi is alive?: {isAlive}");
    }

    public bool GetAlive()
    {
        return isAlive;
    }

    private void ReduceBoredom() {
        boredom--;
    }

    public void SetName(string name){
        this.name=name;
    }
}
