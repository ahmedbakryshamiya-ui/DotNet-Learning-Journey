using System.Reflection;

namespace AdvancedCSharp.Examples;

/// <summary>
/// Reflection inspects metadata about types and members at runtime. Attributes attach declarative metadata that reflection can read.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/advanced-topics/reflection-and-attributes/
/// </remarks>
public static class ReflectionExamples
{
    public static void Run()
    {
        Type type = typeof(Report);
        
        // Read the runtime type name and the public properties declared by the type.
        Console.WriteLine($"Type: {type.Name}");

        foreach (PropertyInfo property in type.GetProperties())
        {
            Console.WriteLine($"Property: {property.Name} ({property.PropertyType.Name})");
        }

        // Retrieve the custom attribute attached to the class.
        ReportInfoAttribute? info = type.GetCustomAttribute<ReportInfoAttribute>();

        if (info is not null)
        {
            Console.WriteLine($"Report category: {info.Category}");
            Console.WriteLine($"Owner: {info.Owner}");
        }

        // Reflection can locate a public method by name and inspect its parameters.
        MethodInfo? method = type.GetMethod(nameof(Report.Generate));
        Console.WriteLine($"Method found: {method is not null}");
        Console.WriteLine($"Parameter count: {method?.GetParameters().Length}");
    }
}

/// <summary>
/// Custom metadata that can be attached to a class and inspected at runtime.
/// </summary>
[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
public sealed class ReportInfoAttribute(string category, string owner) : Attribute
{
    public string Category { get; } = category;
    public string Owner { get; } = owner;
}

/// <summary>
/// Sample type with metadata for the reflection example.
/// </summary>
[ReportInfo("Learning", "Advanced C#")]
public sealed class Report
{
    public string Title { get; set; } = "Monthly Summary";
    public int PageCount { get; set; } = 4;

    public string Generate(string format) => $"Report generated as {format}.";
}
