using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

class Program
{
    static void Main(string[] args)
    {
        var options = new JsonSerializerOptions
        {
            TypeInfoResolver = new DefaultJsonTypeInfoResolver
            {
                Modifiers =
                {
                    (JsonTypeInfo info) =>
                    {
                        if (info.Type != typeof(Base)) return;

                        info.PolymorphismOptions = new()
                        {
                            TypeDiscriminatorPropertyName = "__type",
                            DerivedTypes = { new JsonDerivedType(typeof(Derived), nameof(Derived))}
                        };
                    }
                }
            }
        };

        Base value = new Derived { X = 1, Y = 2 };
        var json = JsonSerializer.Serialize<Base>(value, options);
        Console.WriteLine(json);

        Base? deserialized = JsonSerializer.Deserialize<Base>(json, options);
        Console.WriteLine(deserialized?.ToString());
        Console.ReadKey();
    }
}

//[JsonDerivedType(typeof(Base), typeDiscriminator: "base")]
//[JsonDerivedType(typeof(Derived), typeDiscriminator: "derived")]
public class Base
{
    public int X { get; set; }

    public override string ToString() => $"""
        Base:
            X: {X}
        """;
}

public class Derived : Base
{
    public int Y { get; set; }

    public override string ToString() => $"""
        Derived:
            X: {X}
            Y: {Y}
        """;
}