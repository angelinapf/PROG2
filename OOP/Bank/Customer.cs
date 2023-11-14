using System;
public class Customer
{
    // Attribute
    public string name;
    public int id;
    public Account acc;

    // Constructors
    public Customer(int id, string name, Account acc)
    {
        this.id = id;
        this.name = name;
        this.acc = acc;
    }
}