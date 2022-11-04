using System.Text.RegularExpressions;
var pattern = args[0];
var text = args[1];

var re = new Regex(pattern, RegexOptions.NonBacktracking);
Console.WriteLine(re.IsMatch(text));
