using System;

public class Kata
{
    public static void If(bool c, Action func1, Action func2) => (c ? func1 : func2)();
}