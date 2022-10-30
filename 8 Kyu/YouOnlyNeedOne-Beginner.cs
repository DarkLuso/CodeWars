using System;
using System.Linq;


public class Kata
{
    public static bool Check(object[] a, object x) => Array.Exists(a, b => b.Equals(x));

}