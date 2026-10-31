# Object-Oriented Programming (OOP)

Short explanations and runnable C# examples for the topics in the original OOP notes.

## Run

```bash
dotnet run --project OOP.csproj
```

Choose a topic from the console menu, or open its source file below.

## Topics

### Fundamentals

| Topic | What it covers |
|---|---|
| [Return Types](Examples/01-Fundamentals/01-ReturnTypes.cs) | void and value-returning methods. |
| [Access Modifiers](Examples/01-Fundamentals/02-AccessModifiers.cs) | public, private, protected, internal, protected internal, and private protected. |
| [Classes and Objects](Examples/01-Fundamentals/03-ClassesAndObjects.cs) | Classes, fields, properties, and object creation. |
| [Static Classes](Examples/01-Fundamentals/04-StaticClasses.cs) | Static members and non-instantiable static classes. |
| [Sealed Classes](Examples/01-Fundamentals/05-SealedClasses.cs) | Preventing inheritance. |
| [Partial Classes](Examples/01-Fundamentals/06-PartialClasses.cs) | One class split across source files. |
| [Employee properties](Examples/01-Fundamentals/Employee.Properties.cs) | The properties part of the original partial Employee class. |
| [Employee methods](Examples/01-Fundamentals/Employee.Methods.cs) | The methods part of the original partial Employee class. |
| [Nested Classes](Examples/01-Fundamentals/07-NestedClasses.cs) | A type declared inside another type. |

### Methods

| Topic | What it covers |
|---|---|
| [Pass by Value](Examples/02-Methods/01-PassByValue.cs) | Passing a copy of an argument value. |
| [Pass by Reference](Examples/02-Methods/02-PassByReference.cs) | Using ref to work with the caller's variable. |
| [Method Overloading](Examples/02-Methods/03-MethodOverloading.cs) | Same method name with different parameters. |
| [Static Methods](Examples/02-Methods/04-StaticMethods.cs) | Static and instance method calls. |
| [Extension Methods](Examples/02-Methods/05-ExtensionMethods.cs) | Adding callable methods to existing types. |
| [Recursive Methods](Examples/02-Methods/06-RecursiveMethods.cs) | Iterative and recursive factorial examples. |

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
| [Encapsulation](Examples/04-OOP-Principles/02-Encapsulation.cs) | Access levels and controlled access to members. |
| [Polymorphism](Examples/04-OOP-Principles/03-Polymorphism.cs) | Compile-time overloading and runtime overriding. |
| [Abstraction and Abstract Classes](Examples/04-OOP-Principles/04-AbstractClasses.cs) | Abstract types and required implementations. |
| [Bank Account Example](Examples/08-Practical-Examples/01-BankAccountExample.cs) | A practical combination of classes, inheritance, and encapsulation. |

### Types and Keywords

| Topic | What it covers |
|---|---|
| [Namespaces](Examples/05-Types-And-Keywords/01-Namespaces.cs) | Using namespaces and fully qualified type names. |
| [Namespace samples](Examples/05-Types-And-Keywords/NamespaceSamples.cs) | Bank, Clinet, ParentNameSpace, and nested SonNameSpace. |
| [Structs](Examples/05-Types-And-Keywords/02-Structs.cs) | Defining a custom value type. |
| [Class vs Struct](Examples/05-Types-And-Keywords/03-ClassVsStruct.cs) | Assignment behavior and language differences. |
| [This Keyword](Examples/05-Types-And-Keywords/04-ThisKeyword.cs) | Passing the current object to another method. |
| [Enumerations](Examples/05-Types-And-Keywords/05-Enumerations.cs) | Months, country, and language enums. |
| [Interfaces](Examples/05-Types-And-Keywords/06-Interfaces.cs) | Current and savings accounts implementing a contract. |

### Exceptions and Resources

| Topic | What it covers |
|---|---|
| [Exception Handling](Examples/06-Exceptions-And-Resources/01-ExceptionHandling.cs) | try, catch, finally, and exception filters. |
| [Finalizers and Destructors](Examples/06-Exceptions-And-Resources/02-Finalizers.cs) | Constructor/finalizer behavior and GC timing. |
| [Documentation Comments](Examples/06-Exceptions-And-Resources/03-DocumentationComments.cs) | XML comments for IDE help and generated docs. |
| [IDisposable and Dispose](Examples/06-Exceptions-And-Resources/04-IDisposableAndDispose.cs) | HttpClient cleanup using IDisposable and using. |
| [Async vs .Result](Examples/06-Exceptions-And-Resources/05-AsyncVsResult.cs) | Blocking .Result compared with await. |

### Streams and Files

| Topic | What it covers |
|---|---|
| [Stream I/O](Examples/07-Streams-And-Files/01-StreamIO.cs) | FileStream byte examples, StreamWriter, StreamReader, and File helpers. |
| [DeflateStream](Examples/07-Streams-And-Files/02-DeflateStream.cs) | Compressing and restoring data. |

### Object Relationships

| Topic | What it covers |
|---|---|
| [Association, Aggregation, and Composition](Examples/08-Practical-Examples/02-ObjectRelationships.cs) | Uses-a, has-a, and owns-a relationships. |

[Back to repository home](../README.md)
