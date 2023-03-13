using System.Diagnostics;
using System.Text.RegularExpressions;
using Practice.MainScenario.Threads.Tasks;

namespace Practice;

public static class Program
{
    public static async Task Main(string[] args)
    {
        string input = "5-3EUY8OP6,  5-3EUTY8OP6! 5-3ECMKD65dick5-3EUY8OP655-3EUTY8OP6";
        Regex regex = new Regex(@"(\d-[A-Z0-9]+[^\d-]{2})");
        MatchCollection matches = regex.Matches(input);
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}