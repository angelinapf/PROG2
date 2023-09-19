using System;
public class Account
{
    // Attribute
    public int accNo;
    public string manager = "Emir";
    public double sum;

    // Constructors
    public Account(int accNo, double sum)
    {
        this.accNo = newAccNo;
        this.sum = newSum;
    }

    public void changeSum(double change)
    {
        sum = sum + change;
    }
}