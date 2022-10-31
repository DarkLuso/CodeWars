namespace Solution
{
    public class TwiceAsOldSolution
    {
        public static int TwiceAsOld(int d, int s) => (d - s) * 2 > d ? (d - s) * 2 - d : d - (d - s) * 2;
    }
}