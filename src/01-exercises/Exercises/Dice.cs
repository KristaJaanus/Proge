using System;

public class Dice
{
    private Random Random { get; }
    private int Sides { get; }

    public Dice(int sides)
    {
        this.Sides = sides;
        this.Random = new Random();
    }

    public int Roll ()
    {
    return new Random().Next(1, this.Sides + 1);
    }


    
}
