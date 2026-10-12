# Task 2.1 — Collections Research

## 1. What is `IReadOnlyDictionary<TKey, TValue>` and what is `SortedDictionary<TKey, TValue>`?

`IReadOnlyDictionary<TKey, TValue>` is an interface that provides read-only access to key-value pairs. 
It allows us to retrieve values using keys, check whether a key exists, and enumerate the entries. It does not expose methods for adding or removing entries.

`SortedDictionary<TKey, TValue>` is a collection that stores key-value pairs and automatically keeps them sorted by key. It supports adding, removing, updating, and retrieving entries.

## 2. How does `IReadOnlyDictionary<TKey, TValue>` differ from `Dictionary<TKey, TValue>`?

`Dictionary<TKey, TValue>` is a mutable collection. We can add new entries, update existing values, and remove entries.

`IReadOnlyDictionary<TKey, TValue>` provides a read-only interface. When a method returns this interface, callers cannot add, remove, or update entries through that interface.

However, it does not guarantee that the underlying collection can never change. Another reference may still be able to modify the original dictionary.

## 3. Why would a public method return `IReadOnlyDictionary<TKey, TValue>` instead of `Dictionary<TKey, TValue>`?

A public method may return `IReadOnlyDictionary<TKey, TValue>` when callers only need to read the data.

This communicates the intended usage, prevents callers from modifying the collection through the returned interface, and reduces unnecessary access to modification operations. It also allows the implementation to change without requiring callers to depend directly on `Dictionary<TKey, TValue>`.

## 4. How does `SortedDictionary<TKey, TValue>` differ from `Dictionary<TKey, TValue>` in ordering and lookup speed?

`Dictionary<TKey, TValue>` does not guarantee that entries will be enumerated in sorted key order. Its key lookup is typically O(1) on average.

`SortedDictionary<TKey, TValue>` automatically maintains entries in sorted key order. Its lookup, insertion, and removal operations are typically O(log n), because it uses a balanced search tree.

Therefore, `Dictionary<TKey, TValue>` is generally preferable for fast lookups, while `SortedDictionary<TKey, TValue>` is useful when maintaining sorted order is important.

## 5. When would you choose `SortedDictionary<TKey, TValue>`?

I would choose `SortedDictionary<TKey, TValue>` when I need to access entries by key and enumerate them in sorted key order.

For example, a timetable keyed by session start time can use `SortedDictionary<DateTime, Session>` so that sessions are maintained in chronological order as long as the keys represent their start times.


## Task 2.2 — Pick the Collection

S1 — Dictionary

A `Dictionary` is suitable because it allows fast average O(1) lookups using a student's national ID as the key.

S2 — HashSet

A `HashSet` is suitable because it prevents duplicate tags from being stored.

S3  List

A `List` is suitable because it preserves the order in which grades were entered and allows duplicate values.

S4 — IReadOnlyDictionary

An `IReadOnlyDictionary` is suitable because callers can read course prices without having add, remove, or update operations exposed through the returned interface.

S5 — SortedDictionary

A `SortedDictionary` is suitable because it automatically keeps sessions sorted by their start-time keys, even when sessions are added in a different order.

S6 — IEnumerable

An `IEnumerable` is suitable because it allows the caller to iterate through results and stop early without requiring the method to return a fully materialized list.