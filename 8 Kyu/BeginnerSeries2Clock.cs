public static class Clock
{
    public static int Past(int h, int m, int s) => 1000 * ((((h * 60) + m) * 60) + s);
}