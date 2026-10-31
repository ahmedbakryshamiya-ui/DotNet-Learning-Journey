namespace OOPLearning.Examples;

/// <summary>
/// Access modifiers define the accessibility of types and members. public is available wherever the containing type is accessible; private is limited to the containing type; protected includes derived types; internal is limited to the assembly; protected internal means same assembly OR derived type; private protected means derived type within the same assembly.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers
/// </remarks>
public static class AccessModifiers
{
    public static void Run()
    {
        // Walkthrough: Access modifiers define the accessibility of types and members. public is available wherever the containing type is accessible; private is limited to the containing type; protected includes derived types; internal is limited to the assembly; protected internal means same assembly OR derived type; private protected means derived type within the same assembly.
        AccessDemo demo = new();
        demo.ShowPublicMember();
        demo.ShowMembersInsideTheClass();

        DerivedAccessDemo child = new();
        child.ShowInheritedMembers();

        // The examples below contrast access from the declaring class, a derived class, and other code.
        // private: only inside the declaring type.
        // protected: inside the declaring type and its derived types.
        // internal: anywhere in the same assembly.
        // protected internal: same assembly OR a derived type in another assembly.
        // private protected: derived types in the same assembly only.
    }
}

public class AccessDemo
{
    private string _privateMember = "private";
    protected string ProtectedMember = "protected";
    internal string InternalMember = "internal";
    protected internal string ProtectedInternalMember = "protected internal";
    private protected string PrivateProtectedMember = "private protected";

    public void ShowPublicMember()
    {
        Console.WriteLine("public: accessible from code that can access this type.");
    }

    public void ShowMembersInsideTheClass()
    {
        Console.WriteLine($"Inside declaring class: {_privateMember}");
        Console.WriteLine($"Inside declaring class: {ProtectedMember}");
        Console.WriteLine($"Inside declaring class: {InternalMember}");
        Console.WriteLine($"Inside declaring class: {ProtectedInternalMember}");
        Console.WriteLine($"Inside declaring class: {PrivateProtectedMember}");
    }
}

public class DerivedAccessDemo : AccessDemo
{
    public void ShowInheritedMembers()
    {
        // A derived class can access protected members.
        Console.WriteLine($"Derived class: {ProtectedMember}");
        Console.WriteLine($"Derived class: {InternalMember}");
        Console.WriteLine($"Derived class: {ProtectedInternalMember}");
        Console.WriteLine($"Derived class: {PrivateProtectedMember}");
        // The private member is intentionally inaccessible here.
    }
}
