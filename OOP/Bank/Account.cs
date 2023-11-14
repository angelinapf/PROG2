using System;
public class Account
{
    // Attribute
    private int accNo;
    private string manager = "Emir";
    private double sum;

    // Constructors
    public Account(int accNo, double sum)
    {
        this.accNo = accNo;
        this.sum = sum;
    }

    // Methods
    public void changeSum(double change)
    {
        sum = sum + change;
    }

    // Getters & setters
    public double getSum()
    {
        return (this.sum);
    }

    public void setSum(double sum)
    {
        if (sum < 0)
        {
            Console.WriteLine("No negative sums");
        }
        else
        {
            this.sum = sum;

        }
    }

    public string getManager(){
        return manager;
    }


}