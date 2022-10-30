namespace Solution
{
    public static class Program
    {
        public static double basicOp(char o, double x, double y) => o switch
        {
            '+' => x + y,
            '-' => x - y,
            '*' => x * y,
            '/' => x / y,
            '%' => x % y
        };
    }
}