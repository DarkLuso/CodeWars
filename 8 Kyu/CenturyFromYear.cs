public static class Kata
{
    public static int СenturyFromYear(int y) => y % 100 == 0 ? y / 100 : y / 100 + 1;
}