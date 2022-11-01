public class Kata
{
    public static bool Feast(string b, string d) => d.StartsWith(b[0]) && d.EndsWith(b[b.Length - 1]);
}