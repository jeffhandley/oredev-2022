using SessionMatch.SessionData;
using System.Text.RegularExpressions;

namespace SessionMatch
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            if (args?.Length is null or 0) throw new ArgumentNullException(nameof(args));
            ArgumentNullException.ThrowIfNullOrEmpty(args[0]);

            var regex = args[0].ToLowerInvariant() switch
            {
                ".net" or "dotnet" => DotNet(),
                _ => throw new ArgumentException("Unrecognized tag", args[0])
            };

            using var sessionFile = File.OpenRead("Sessions.json");
            var sessions = System.Text.Json.JsonSerializer.Deserialize<SessionData.Root>(sessionFile)?.Sessions ?? Enumerable.Empty<Session>();

            bool hasMatch = false;
            foreach (var session in sessions)
            {
                Console.WriteLine(session.TimeOfDay);
            }
            //foreach (string session in Directory.EnumerateFiles("Sessions", "*.txt"))
            //{
            //    var text = File.ReadAllText(session);

            //    if (regex.IsMatch(text))
            //    {
            //        hasMatch = true;
            //        Console.WriteLine(session[9..^4]);
            //    }
            //}

            if (!hasMatch)
            {
                Console.WriteLine("No matching sessions");
            }
        }

        [GeneratedRegex("(.net|dotnet)", RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.Compiled, "en-US")]
        private static partial Regex DotNet();
    }
}