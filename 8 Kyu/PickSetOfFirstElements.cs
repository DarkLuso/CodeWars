using System.Linq;

public class Kata
{
    public static object[] TakeFirstElements(object[] a, int n = 1) => a.Take(n).ToArray();
}