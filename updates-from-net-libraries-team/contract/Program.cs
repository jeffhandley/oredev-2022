using System.Reflection;
using System.Security.Cryptography;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;

namespace contract;
class Program
{
    static void Main(string[] args)
    {
        //var options = new JsonSerializerOptions { TypeInfoResolver = new PropertyPrefixer() };
        var options = new JsonSerializerOptions
        {
            TypeInfoResolver = new DefaultJsonTypeInfoResolver
            {
                Modifiers = { ExcludePrivateInfo, AddPrivateFields, PrefixProperties, LowercaseProperties }
            }
        };

        //var json = JsonSerializer.Serialize(new { Value = 42 }, options);
        var json = JsonSerializer.Serialize(new Model { FirstName = "Jeff", LastName = "Handley", TaxID = "*****" }, options);

        Console.WriteLine(json);
        Console.ReadKey();
    }

    static void AddPrivateFields(JsonTypeInfo info)
    {
        if (info.Kind == JsonTypeInfoKind.Object)
        {
            foreach (var field in info.Type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic))
            {
                var propInfo = info.CreateJsonPropertyInfo(field.FieldType, "_" + field.Name);
                propInfo.Get = obj => field.GetValue(obj);

                info.Properties.Add(propInfo);
            }
        }
    }

    static void ExcludePrivateInfo(JsonTypeInfo info)
    {
        if (info.Kind == JsonTypeInfoKind.Object)
        {
            foreach (var property in info.Properties)
            {
                if (property.AttributeProvider is ICustomAttributeProvider provider &&
                    provider.IsDefined(typeof(PrivateInfoAttribute), inherit: true))
                {
                    property.Get = null;
                    property.Set = null;                    
                }
            }
        }
    }

    static void PrefixProperties(JsonTypeInfo info)
    {
        if (info.Kind == JsonTypeInfoKind.Object)
        {
            foreach (var property in info.Properties)
            {
                property.Name = "DEMO_" + property.Name;
            }
        }
    }

    static void LowercaseProperties(JsonTypeInfo info)
    {
        if (info.Kind == JsonTypeInfoKind.Object)
        {
            foreach (var property in info.Properties)
            {
                property.Name = property.Name.ToLower();
            }
        }
    }

    public class PropertyPrefixer : DefaultJsonTypeInfoResolver
    {
        public override JsonTypeInfo GetTypeInfo(Type type, JsonSerializerOptions options)
        {
            var info = base.GetTypeInfo(type, options);

            if (info.Kind == JsonTypeInfoKind.Object)
            {
                foreach (var property in info.Properties)
                {
                    property.Name = "DEMO_" + property.Name;
                }
            }

            return info;
        }
    }
}
