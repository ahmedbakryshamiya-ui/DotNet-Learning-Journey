# Object-Oriented Programming (OOP)

Short explanations and runnable C# examples for OOP and related topics.

## Run

```bash
dotnet run --project 02-OOP.csproj
```

Choose a topic from the console menu, or open its source file below.

## Topics

### Fundamentals

| Topic | What it covers |
|---|---|
| [Return Types](Examples/01-Fundamentals/01-ReturnTypes.cs) | void and value-returning methods. |
| [Access Modifiers](Examples/01-Fundamentals/02-AccessModifiers.cs) | public, private, protected, and internal. |
| [Classes and Objects](Examples/01-Fundamentals/03-ClassesAndObjects.cs) | Creating objects from a class. |
| [Static Classes](Examples/01-Fundamentals/04-StaticClasses.cs) | Types that contain static members. |
| [Sealed Classes](Examples/01-Fundamentals/05-SealedClasses.cs) | Preventing inheritance. |
| [Partial Classes](Examples/01-Fundamentals/06-PartialClasses.cs) | One class split across source files. |
| [Nested Classes](Examples/01-Fundamentals/07-NestedClasses.cs) | A type declared inside another type. |

### Methods

| Topic | What it covers |
|---|---|
| [Pass by Value](Examples/02-Methods/01-PassByValue.cs) | Passing a copy of an argument value. |
| [Pass by Reference](Examples/02-Methods/02-PassByReference.cs) | Using ref to work with the caller's variable. |
| [Method Overloading](Examples/02-Methods/03-MethodOverloading.cs) | Same method name with different parameters. |
| [Static Methods](Examples/02-Methods/04-StaticMethods.cs) | Static and instance method calls. |
| [Extension Methods](Examples/02-Methods/05-ExtensionMethods.cs) | Adding callable methods to existing types. |
| [Recursive Methods](Examples/02-Methods/06-RecursiveMethods.cs) | A method calling itself with a base case. |

### Constructors

| Topic | What it covers |
|---|---|
| [Default Constructor](Examples/03-Constructors/01-DefaultConstructor.cs) | Initializing an object without arguments. |
| [Parameterized Constructor](Examples/03-Constructors/02-ParameterizedConstructor.cs) | Passing initial values to a constructor. |
| [Copy Constructor](Examples/03-Constructors/03-CopyConstructor.cs) | Creating an object from another object. |
| [Private Constructor](Examples/03-Constructors/04-PrivateConstructor.cs) | Restricting direct object creation. |
| [Static Constructor](Examples/03-Constructors/05-StaticConstructor.cs) | One-time initialization for a type. |

### OOP Principles

| Topic | What it covers |
|---|---|
| [Inheritance](Examples/04-OOP-Principles/01-Inheritance.cs) | Reusing and extending a base class. |
| [Encapsulation](Examples/04-OOP-Principles/02-Encapsulation.cs) | Protecting data behind controlled methods. |
| [Polymorphism](Examples/04-OOP-Principles/03-Polymorphism.cs) | Virtual methods and runtime dispatch. |
| [Abstraction and Abstract Classes](Examples/04-OOP-Principles/04-AbstractClasses.cs) | Abstract types and required implementations. |

### Types and Keywords

| Topic | What it covers |
|---|---|
| [Namespaces](Examples/05-Types-And-Keywords/01-Namespaces.cs) | Organizing related types. |
| [Structs](Examples/05-Types-And-Keywords/02-Structs.cs) | Defining a custom value type. |
| [Class vs Struct](Examples/05-Types-And-Keywords/03-ClassVsStruct.cs) | Reference-type and value-type assignment. |
| [This Keyword](Examples/05-Types-And-Keywords/04-ThisKeyword.cs) | Referencing the current object. |
| [Enumerations](Examples/05-Types-And-Keywords/05-Enumerations.cs) | Named constant values with enum. |
| [Interfaces](Examples/05-Types-And-Keywords/06-Interfaces.cs) | Contracts implemented by classes. |

### Exceptions and Resources

| Topic | What it covers |
|---|---|
| [Exception Handling](Examples/06-Exceptions-And-Resources/01-ExceptionHandling.cs) | try, catch, finally, and exception filters. |
| [Finalizers and Destructors](Examples/06-Exceptions-And-Resources/02-Finalizers.cs) | Finalization and garbage collection timing. |
| [Documentation Comments](Examples/06-Exceptions-And-Resources/03-DocumentationComments.cs) | XML comments for IDE help and generated docs. |
| [IDisposable and Dispose](Examples/06-Exceptions-And-Resources/04-IDisposableAndDispose.cs) | Deterministic resource cleanup. |
| [Async vs .Result](Examples/06-Exceptions-And-Resources/05-AsyncVsResult.cs) | Awaiting work without blocking. |

### Streams and Files

| Topic | What it covers |
|---|---|
| [Stream I/O](Examples/07-Streams-And-Files/01-StreamIO.cs) | FileStream, StreamReader, and StreamWriter. |
| [DeflateStream](Examples/07-Streams-And-Files/02-DeflateStream.cs) | Compressing and restoring data. |

### Practical Examples

| Topic | What it covers |
|---|---|
| [Bank Account Example](Examples/08-Practical-Examples/01-BankAccountExample.cs) | Combining constructors, encapsulation, and inheritance. |
| [Object Relationships](Examples/08-Practical-Examples/02-ObjectRelationships.cs) | Association, aggregation, and composition. |

[Back to repository home](../README.md)