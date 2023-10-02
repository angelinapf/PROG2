using System;

public class Car
{
    // Attributes
    private int id;
    private string brand;
    private double speed = 0.0;
    private int milage = 0;
    private string owner;
    private int value;

    // Constructors
    public Car(int id, string brand, string owner, int value)
    {
        this.id = id;
        this.brand = brand;
        this.owner = owner;
        this.value = value;
    }

    // Methods
    public void speedUp(double increase)
    {
        // Don't have to write 'this.' in this scenario
        if (this.speed + increase <= 220)
        {
            this.speed = this.speed + increase;
        }
        else
        {
            Console.WriteLine("Too speedy");
        }
    }

    public void slowDown(double decrease)
    {
        if (this.speed - decrease <= 0)
        {
            this.speed = this.speed - decrease;
        }
        else
        {
            Console.WriteLine("Too slow; speed cannot be below 0");
        }
    }

    public void stop()
    {
        speed = 0;
    }

    public int getId()
    {
        return id;
    }

    public string getBrand()
    {
        return brand;
    }

    public double getSpeed()
    {
        return speed;
    }

    public int getMilage(){
        return milage;
    }

    public string getOwner(){
        return owner;
    }

    public void setOwner(string owner){
        this.owner = owner;
    }

    public int getValue(){
        return value;
    }
}
