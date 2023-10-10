using System;

public class Student
{
    // Attributes
    private string name;
    private string address;
    private int numCourses = 0;
    private string[] courses = {"DAODAC", "PRRPRR2", "GRÄGRÄ01"};
    private int[] grades = { 5, 1, 3 };

    // Constructor
    public Student(string name, string address)
    {
        this.name = name;
        this.address = address;
    }

    // Methods
    public string getName()
    {
        return name;
    }

    public string getAddress()
    {
        return address;
    }

    public void setAddress(string address)
    {
        this.address = address;
    }

    //public string toString() { }

    public void addCourseGrade(string course, int grade) { }

    public string printGrades()
    {
        Console.WriteLine(
            $"Grades:\n{courses[0]}:{grades[0]}\n{courses[1]}:{grades[1]}\n{courses[2]}:{grades[2]}"
        );
    }

    //public double getAverageGrade() { }
}
