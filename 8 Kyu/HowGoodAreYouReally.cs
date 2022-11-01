using System.Linq;

public class Kata
{
    public static bool BetterThanAverage(int[] c, int y) => (c.Sum() + y) / (c.Length + 1) < y;
}