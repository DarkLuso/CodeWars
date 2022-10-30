public class Kata
{
    public static string UpdateLight(string c) => c == "green" ? "yellow" : c == "yellow" ? "red" : "green";
}