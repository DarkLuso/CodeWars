using System;
using System.Linq;

public static class Kata
{
    public static int SumOfDifferences(int[] a)
    {
        int r = 0;
        a = a.OrderByDescending(x => x).ToArray();

        for (int y = 0; y + 1 < a.Length; y++)
        {
            r += a[y] - a[y + 1];
        }

        return r;
    }
}