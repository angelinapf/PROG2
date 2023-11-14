namespace Employees;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Employee myEmployee = new Employee("Nazanin", 120, 26);
        Intern myIntern = new Intern("Felicia", 94, 1);
        Manager myManager = new Manager("Alina", 196, 20);

        myEmployee.Work(10);
        myIntern.Work(11);
        myManager.Work(34);

        myEmployee.calcSalary();
        myIntern.calcSalary();
        myManager.calcSalary();
    }
}
