using System;
using System.Linq;

namespace Solution
{
    public static class Program
    {
        public static string RepeatStr(int n, string s) => string.Concat(Enumerable.Repeat(s, n));
        //{
        //string result = "";
        //for(int x = 0; x < n; x++) {
        //result += s;
        //}
        //return result;
        //}
    }
}