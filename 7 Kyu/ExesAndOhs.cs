using System.Linq;
using System;
public static class Kata
{
    public static bool XO(string input)
    {

        int o = input.Where(z => char.ToUpperInvariant(z) == 'O').Count();
        int x = input.Where(y => char.ToUpperInvariant(y) == 'X').Count();

        return o == x ? true : false;
    }
}