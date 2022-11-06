class Program
{
    static void Main(string[] args)
    {
        // This causes "Two" to be returned
        // first in .NET 6 and earlier.
        typeof(Data).GetProperty("Two");

        foreach (var prop in typeof(Data).GetProperties())
        {
            Console.WriteLine(prop.Name);
        }
    }
}

class Data
{
    public string? One { get; set; }
    public string? Two { get; set; }
    public string? Three { get; set; }
}


