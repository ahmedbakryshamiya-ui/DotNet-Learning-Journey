namespace OOPLearning.Examples;

/// <summary>
/// Access modifiers control which code can use a type or member.
/// </summary>
public static class AccessModifiers
{
    public static void Run()
    {
        AccessDemo demo = new();

        Console.WriteLine(demo.Name);
        demo.ShowDetails();

        // Private members are available only inside their declaring type.
        // Protected members are available inside the type and derived types.
        // Internal members are available inside the same assembly.
    }
}

public class AccessDemo
{
    private string _secret = "Private data";
    protected string ProtectedMessage = "Protected data";
    internal string InternalMessage = "Internal data";

    public string Name { get; set; } = "Access modifier example";

    public void ShowDetails()
    {
        Console.WriteLine(_secret);
        Console.WriteLine(ProtectedMessage);
        Console.WriteLine(InternalMessage);
    }
}
