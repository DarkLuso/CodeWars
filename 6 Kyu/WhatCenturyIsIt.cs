public class Kata
{
    public static string WhatCentury(string year)
    {
        int y = int.Parse(year);

        y = y % 100 == 0 ? y / 100 : y / 100 + 1;

        return y / 10 == 1 ? y + "th" : (y % 10) switch
        {
            1 => y + "st",
            2 => y + "nd",
            3 => y + "rd",
            _ => y + "th"
        };
    }
}