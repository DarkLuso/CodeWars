using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int[] CountPositivesSumNegatives(int[] input)
    {

        int posCount = 0;
        int negSum = 0;

        if (input == null || input.Length == 0) return new int[0] { };

        foreach (int n in input)
        {

            if (n > 0) posCount++;
            else if (n < 0) negSum += n;
        }

        return new int[2] { posCount, negSum };

    }

}