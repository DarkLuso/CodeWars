using System.Linq;
public static class Kata
{
    public static int CountSheeps(bool[] s) => s.Count(x => x == true);
}