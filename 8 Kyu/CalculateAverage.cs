using System.Linq;

class AverageSolution
{
    public static double FindAverage(double[] a) => a.Any() ? a.Sum() / a.Length : 0;
}