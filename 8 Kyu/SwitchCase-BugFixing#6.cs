using System;

public class Kata
{
    public static double EvalObject(double value1, double value2, char o) => o switch
    {
        '+' => value1 + value2,
        '-' => value1 - value2,
        '/' => value1 / value2,
        '*' => value1 * value2,
        '%' => value1 % value2,
        '^' => Math.Pow(value1, value2),
        _ => 0
    };
}