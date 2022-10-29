using System;

public class Kata
{
    public static int Cats(int s, int f)
    {
        int j = 0;
        int d = f - 2;

        while (s < f) { _ = s == d ? s++ : s += 3; j++; }

        return j;//Mew

    }
}