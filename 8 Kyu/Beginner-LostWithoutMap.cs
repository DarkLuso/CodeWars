using System.Linq;

public class Kata
{
    public static int[] Maps(int[] x) => x.Select(y => y * 2).ToArray();
}