public class Employee
{
    // Attributes
    protected string name;
    protected double hourlyWage;
    protected int workedHours;

    // Constructors
    public Employee(string name, double hourlyWage, int workedHours)
    {
        this.name = name;
        this.hourlyWage = hourlyWage;
        this.workedHours = workedHours;
    }

    // Methods
    public virtual void Work(int hours)
    {
        workedHours = hours + workedHours;
        Console.WriteLine($"{name} has worked {workedHours} hours.");
    }

    public virtual void calcSalary()
    {
        double salary = workedHours * hourlyWage;
        Console.WriteLine($"{name}'s salary is {salary}.");
    }
}
