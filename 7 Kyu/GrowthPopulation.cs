using System;

class Arge
{

    public static int NbYear(int p0, double percent, int aug, int p)
    {

        int x = 0;

        while (p0 < p)
        {

            p0 += Convert.ToInt32(Math.Floor(p0 * (percent / 100) + aug));

            x++;

        }

        return x;

    }
}