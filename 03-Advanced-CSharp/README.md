# Advanced C#

A new learning stage focused on modern C# language features, reusable programming techniques, asynchronous workflows, runtime metadata, and memory-aware code.

This section uses the same approach as Basics and OOP: short explanations, runnable examples, comments beside important statements, and links to Microsoft Learn.

## Run

Open [Advanced-CSharp.slnx](Advanced-CSharp.slnx) in Visual Studio, or run:

```bash
dotnet run --project Advanced-CSharp.csproj
```

The menu lets you run one topic at a time. The project targets .NET 10 and uses no third-party packages.

## Learning path

| # | Topic | What it teaches |
|---:|---|---|
| 01 | [Generic Types and Methods](Examples/01-Generics/Generics.cs) | Type parameters, reusable algorithms, and generic constraints. |
| 02 | [Delegates](Examples/02-Delegates/Delegates.cs) | Custom delegates and the built-in `Func`, `Action`, and `Predicate` types. |
| 03 | [Events](Examples/03-Events/Events.cs) | Publish-subscribe notifications, event arguments, subscribing, and unsubscribing. |
| 04 | [Lambda Expressions](Examples/04-Lambdas/LambdaExpressions.cs) | Expression and statement lambdas, captured variables, and closures. |
| 05 | [LINQ](Examples/05-LINQ/LinqQueries.cs) | Filtering, ordering, projection, deferred execution, and materialization. |
| 06 | [Generic Collections](Examples/06-Collections/GenericCollections.cs) | List, Dictionary, HashSet, Queue, and Stack use cases. |
| 07 | [Iterators and yield](Examples/07-Iterators/Iterators.cs) | Producing sequences on demand with `yield return` and `yield break`. |
| 08 | [Records](Examples/08-Records/Records.cs) | Value-based equality and non-destructive mutation with `with`. |
| 09 | [Pattern Matching](Examples/09-PatternMatching/PatternMatching.cs) | Type, relational, and property patterns with switch expressions. |
| 10 | [Async, Await, and Tasks](Examples/10-AsyncTasks/AsyncTasks.cs) | Asynchronous operations, Task, and concurrent work with Task.WhenAll. |
| 11 | [Cooperative Cancellation](Examples/11-Cancellation/CancellationExamples.cs) | CancellationTokenSource, CancellationToken, and OperationCanceledException. |
| 12 | [Asynchronous Streams](Examples/12-AsyncStreams/AsyncStreams.cs) | IAsyncEnumerable, async iterators, and await foreach. |
| 13 | [Attributes and Reflection](Examples/13-Reflection/ReflectionExamples.cs) | Custom attributes and inspecting types, properties, and methods at runtime. |
| 14 | [Span and Memory](Examples/14-SpanMemory/SpanMemory.cs) | Working with slices of contiguous memory and avoiding unnecessary copies. |

## Recommended order

Follow the menu from top to bottom. Generics and delegates are useful foundations for events, LINQ, and collections. Iterators and records build on those ideas. The asynchronous topics are grouped together, followed by reflection and memory-oriented APIs.

## Microsoft Learn references

- [Generics](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/generics)
- [Delegates](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/)
- [Events](https://learn.microsoft.com/en-us/dotnet/csharp/events-overview)
- [Lambda expressions](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions)
- [LINQ](https://learn.microsoft.com/en-us/dotnet/csharp/linq/)
- [Collections](https://learn.microsoft.com/en-us/dotnet/standard/collections/)
- [Iterators](https://learn.microsoft.com/en-us/dotnet/csharp/iterators)
- [Records](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/records)
- [Pattern matching](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/functional/pattern-matching)
- [Asynchronous programming](https://learn.microsoft.com/en-us/dotnet/csharp/asynchronous-programming/)
- [Cancellation in managed threads](https://learn.microsoft.com/en-us/dotnet/standard/threading/cancellation-in-managed-threads)
- [Asynchronous streams](https://learn.microsoft.com/en-us/dotnet/csharp/asynchronous-programming/generate-consume-asynchronous-stream)
- [Reflection and attributes](https://learn.microsoft.com/en-us/dotnet/csharp/advanced-topics/reflection-and-attributes/)
- [Memory and Span](https://learn.microsoft.com/en-us/dotnet/standard/memory-and-spans/)

[Back to repository home](../README.md)
