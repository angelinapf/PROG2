using System;

public class Player
{
    // Attributes
    public int health;
    public int attack;
    private string name;

    // Constructors
    public Player(int health, int attack, string name){
        this.health = health;
        this.attack = attack;
        this.name = name;
    }

    // Getters & setters
    public string getName(){
        return name;
    }

}