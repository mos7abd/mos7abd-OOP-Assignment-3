**LinkedIn Profile:**  
https://www.linkedin.com/in/mo-abdella

**Note:**  
The required LinkedIn technical posts for this assignment have been completed and included below as drafts.

As mentioned in the previous assignment, I prefer to publish LinkedIn posts when they provide meaningful value to my professional development. Therefore, these posts have not been published on LinkedIn. However, the required technical content, explanations, C# examples, and practical applications have been prepared for all the assigned topics.

---------------------------------------------------------------------------------------------------------------
1-
# List.Contains() vs HashSet.Contains() — A Real Performance Test

Both methods check whether an item exists, but their lookup costs are different.

- `List<T>.Contains()` uses a linear search: O(n).
- `HashSet<T>.Contains()` provides O(1) average lookup time thanks to hashing.

I tested both in C# using `Stopwatch`, with 100,000 integers and 10,000 searches for missing values. Both collections were created before timing the lookups.

```csharp
var sw = Stopwatch.StartNew();

for (int i = 0; i < repetitions; i++)
    numbers.Contains(-i - 1);

sw.Stop();
Console.WriteLine($"List: {sw.Elapsed.TotalMilliseconds:F3} ms");

sw.Restart();

for (int i = 0; i < repetitions; i++)
    numberSet.Contains(-i - 1);

sw.Stop();
Console.WriteLine($"HashSet: {sw.Elapsed.TotalMilliseconds:F3} ms");
```

## Results

| Collection | Lookup time |
| List       | 80.736 ms |
| HashSet    | 0.047 ms |

In this run, `HashSet` was approximately 1,718 times faster for these lookups.

The takeaway: when you repeatedly check for items in a large collection, choosing the right data structure can make a significant difference. However, creating a `HashSet` has its own cost, so the best choice depends on the use case.

#CSharp #DotNet #Performance #Programming

-----------------------------------------------------------------------------------------------------------------
2-
# Understanding yield return in C#

I experimented with `yield return` in C# and noticed something interesting: calling a method doesn't necessarily mean its code runs immediately.

```csharp
IEnumerable<int> GetNumbers()
{
    Console.WriteLine("Generating numbers...");

    yield return 1;
    yield return 2;
    yield return 3;
}
```

The code starts executing when the result is enumerated, and each value is produced as the caller requests it. This is called lazy evaluation.

I also tested what happens when I iterate over the same result twice. The message appeared twice because the iterator's logic ran again.

One thing to keep in mind: repeated enumeration can repeat expensive work, such as database queries. If I need to reuse the same results, calling `ToList()` once can be a better option.

Understanding when code actually executes is just as important as understanding what it returns.


---------------------------------------------------------------------------------------------
3-
# Span<T> in C# — Working with data without unnecessary copies

When working with arrays and strings, creating new copies just to access a small portion of data can lead to unnecessary memory allocations.

`Span<T>` provides a way to work with a slice of existing data without creating a new copy.

For example:

```csharp
string text = "Hello World";

string part1 = text.Substring(0, 5);

ReadOnlySpan<char> part2 = text.AsSpan(0, 5);
```

Both represent `Hello`, but `Substring()` creates a new string, while `AsSpan()` provides a view of the existing string data.

For arrays, `Span<T>` can also modify the original elements without creating a separate array.

One important limitation: `Span<T>` cannot be used across an `await` suspension point in the usual way. `Memory<T>` is a suitable alternative when data needs to be retained across asynchronous operations.

Understanding `Span<T>` is a useful step toward writing more memory-efficient C# code.

-----------------------------------------------------------------------------------------------------------------------

# Extension Members in C# 14

C# 14 introduces a new way to define extension members, building on the extension methods we've been using for years.

Traditionally, we add an extension method like this:

```csharp
public static class StringExtensions
{
    public static bool IsLong(this string value)
    {
        return value.Length > 10;
    }
}
```

With the new extension block syntax, we can write:

```csharp
public static class StringExtensions
{
    extension(string value)
    {
        public bool IsLong => value.Length > 10;
    }
}
```

Now `IsLong` is an extension property, so it can be accessed like a regular property:

```csharp
string text = "Hello, world!";
Console.WriteLine(text.IsLong);
```

C# 14 also supports static extension members, opening up more ways to extend existing types.

The interesting part isn't just the new syntax. It's how extension members can make APIs feel more natural to use, especially when adding functionality to types we don't own.

#CSharp #DotNet #CSharp14 #DotNet10 #Programming