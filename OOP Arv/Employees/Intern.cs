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
        workedHours = hours + workedHours;
        if (workedHours < 10)
        {
            Console.WriteLine($"{name} have worked {workedHours} hours in total.");
        }
        else
        {
            Console.WriteLine($"{name} has exceeded their 10 hours, and can't work anymore.");
        }
    }

    public override void calcSalary()
    {
        double salary = workedHours * hourlyWage;
        Console.WriteLine($"{name}'s salary is {salary}.");
    }
}
