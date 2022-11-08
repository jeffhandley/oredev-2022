using System.Text.RegularExpressions;

namespace sessionre;

partial class Program
{
    static void Main(string[] args)
    {
        var titles = File.ReadAllLines("session-titles.txt");
        var pattern = SessionMatch();

        foreach (var title in titles)
        {
            var match = pattern.Match(title);

            if (match.Success)
            {
                Console.WriteLine(title);
                Console.Write(new string(' ', match.Index));
                Console.WriteLine(new string('^', match.Length));
            }
        }
    }

    [GeneratedRegex(@"\.net", RegexOptions.IgnoreCase, "en-US")]
    private static partial Regex SessionMatch();
}
