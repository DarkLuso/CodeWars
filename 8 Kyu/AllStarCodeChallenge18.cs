using System.Linq;

class Kata
{
    public static int StrCount(string s, string l) => s.ToCharArray().Where(x => x.ToString() == l).Count();
}