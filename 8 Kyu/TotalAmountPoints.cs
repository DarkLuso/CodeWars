using System;

public static class Kata
{

    public static int TotalPoints(string[] games)
    {

        int points = 0;

        foreach (string g in games)
        {

            int mS = Convert.ToInt32(g.Substring(0, 1));
            int eS = Convert.ToInt32(g.Substring(2));

            points += mS > eS ? 3 : (mS == eS) ? 1 : 0;

        }

        return points;
    }
}