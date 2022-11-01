using System.Text.RegularExpressions;

public class Kata
{
    public static string Shortcut(string i) => Regex.Replace(i, "[aeiou]", "");
}