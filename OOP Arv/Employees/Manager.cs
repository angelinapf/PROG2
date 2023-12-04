public class Manager : Employee
{
    // Attributes
    double bonus = 1000;

    public Manager(string name, double hourlyWage, int workedHours)
        : base(name, hourlyWage, workedHours)
    {
        this.name = name;
        this.hourlyWage = hourlyWage;
        this.workedHours = workedHours;
    }

    public override void Work(int hours)
    {
        workedHours = hours + workedHours;
        if (workedHours > 40)
        {
            Console.WriteLine($"{name} is eligible for a bonus!");
        }
        else
        {
            Console.WriteLine($"{name} has worked {workedHours} hours.");
        }
    }

    public override void calcSalary()
    {
        double salary = workedHours * hourlyWage;

        if (workedHours > 40)
        {
            Console.WriteLine($"{name} got a bonus for working more than 40 hours!");
            salary = bonus + salary;
            Console.WriteLine($"{name}'s salary is {salary}.");
        }
        else
        {
            Console.WriteLine($"{name}'s salary is {salary}.");
        }
    }

    public void bonusCalc(){
        Console.WriteLine("How many bonuses do you think you have gotten this month?: ");
        double calculatedBonus = bonus + salary;
    }
}
