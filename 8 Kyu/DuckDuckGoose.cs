using System;

public class Kata
{
    public static string DuckDuckGoose(Player[] p, int g) => p[(g - 1) % p.Length].Name;
}
public class Player
{
    public string Name { get; set; }

    public Player(string name)
    {
        this.Name = name;
    }
}