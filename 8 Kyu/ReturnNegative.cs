using System;

public static class Kata
{
    public static int MakeNegative(int n) => n <= 0 ? n : n - n * 2;
}