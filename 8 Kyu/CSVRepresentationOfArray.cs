using System;
using System.Linq;

public static class Kata
{
    public static string ToCsvText(int[][] array)
    {
        string r = "";

        foreach (int[] a in array)
        {
            foreach (int n in a)
            {
                r += n + ",";
            }

            r = r.Remove(r.Length - 1);
            r += "\n";

        }
        r = r.Remove(r.Length - 1);

        return r;
    }
}