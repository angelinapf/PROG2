public class Intern : Employee
{
    // Attributes

    // Constructors
    public Intern(string name, double hourlyWage, int workedHours) : base(name, hourlyWage, workedHours)
    {
        this.name = name;
        this.hourlyWage = hourlyWage;
        this.workedHours = workedHours;
    }

    // Methods
    public override void Work(int hours)
    {
        if (workedHours < 10)
        {
            workedHours = hours + workedHours;
            Console.WriteLine($"{name} have worked {workedHours} hours in total.");
        }
        else
        {
            Console.WriteLine($"{name} has exceeded their 10 hours, and can't work anymore.");
        }
    }
}
