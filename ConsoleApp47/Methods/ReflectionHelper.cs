using System.Reflection;
namespace ConsoleApp47.Methods;
public static class ReflectionHelper
{
    public static void InspectObject(object obj)
    {
        if (obj == null)
        {
            Console.WriteLine("The object is null.");
            return;
        }
        Type type = obj.GetType();
        Console.WriteLine($"Inspecting object of type: {type.FullName}");
        // Inspect properties
        var properties = type.GetProperties();
        Console.WriteLine("Properties:");
        foreach (var property in properties)
        {
            var value = property.GetValue(obj);
            Console.WriteLine($"- {property.Name} ({property.PropertyType.Name}): {value}");
        }
        // Inspect fields
        var fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
        Console.WriteLine("Private Fields:");
        foreach (var field in fields)
        {
            var value = field.GetValue(obj);
            Console.WriteLine($"- {field.Name} ({field.FieldType.Name}): {value}");
        }
        // Inspect methods
        var methods = type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly);
        Console.WriteLine("Methods:");
        foreach (var method in methods)
        {
            Console.WriteLine($"- {method.Name} ({method.ReturnType.Name})");
        }
        var attributes = type.GetCustomAttributes();
        Console.WriteLine("Attributes:");
        foreach (var attribute in attributes)
        {
            Console.WriteLine($"- {attribute.GetType().Name}");
        }
    }
}
