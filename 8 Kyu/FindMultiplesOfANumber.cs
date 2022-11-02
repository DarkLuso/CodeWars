using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static List<int> FindMultiples(int i, int l)
    => Enumerable.Range(1, l).Where(x => x % i == 0).ToList();
}