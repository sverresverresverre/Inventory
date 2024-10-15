using System;

public class Weapon : Item
{
    public int MinDamage = 10;

    public int MaxDamage = 50;

    public int Attack()
    {
        return Random.Shared.Next(MinDamage, MaxDamage);
    }
}

