public static class Kata
{
    public static int Pillars(int n, int d, int w) => n == 1 ? 0 : (d * (n - 1)) * 100 + w * (n - 2);
}