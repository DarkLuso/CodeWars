using System;
using System.Linq;

public static class Kata
{
    public static string MultiTable(int n)
      => String.Join("\n",
        Enumerable.Range(0, 10)
          .Select((x, i) => $"{i + 1} * {n} = {(i + 1) * n}"));
}