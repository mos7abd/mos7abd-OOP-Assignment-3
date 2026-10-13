# OOP Assignment 3 — Advanced .NET Engineering Diploma

**Name:** Mostafa Abdellah  
**Branch:** `assignment/1-7`

## Overview

This repository contains the solutions for Assignment 3 of the Advanced .NET Engineering Diploma at Simulation Academy.

The assignment focuses on refactoring existing code, working with collections and extension methods, implementing generic data structures, and explaining key C# and .NET concepts through technical LinkedIn posts.

Each part is organized in its own directory to keep the source code, written answers, and practical examples easy to review.

## Repository Structure

```text
.
├── README.md
├── Refactoring/
│   ├── part-01/
│   ├── part-02/
│   └── part-03/
├── Collections/
│   ├── Answers.md
│   └── src/
│       ├── CollectionsLab.csproj
│       ├── Program.cs
│       └── StringValidationExtensions.cs
├── Generics/
│   ├── Answers.md
│   └── src/
│       ├── GenericsLab.csproj
│       ├── Program.cs
│       ├── Contracts/
│       ├── Extensions/
│       ├── Models/
│       └── Stores/
└── LinkedIn/
    └── linked.md
```

## Assignment Parts

### Part 1 — Refactoring

This part focuses on identifying and improving code design issues across three sections.

The solutions demonstrate how to improve code readability, maintainability, separation of responsibilities, and overall structure while preserving the intended behavior.

Each section contains its own source code and supporting documentation.

### Part 2 — Collections and Extension Methods

This part covers collection operations, performance considerations, and the implementation of custom extension methods in C#.

The work includes written answers and practical examples, with `StringValidationExtensions.cs` implementing the required string validation functionality.

A console application is included to test the implemented methods against different input cases.

### Part 3 — Generics

This part explores generic programming and reusable data structures in C#.

The implementation includes:

- Generic models and the `IHasId` interface.
- Generic stores and ID-based item management.
- CRUD operations for students and courses.
- Extension methods for working with collections, including paging.
- Practical examples and tests in the console application.

Written explanations and answers are provided in `Generics/Answers.md`.

### Part 4 — LinkedIn Technical Posts

This part covers four technical topics related to C# and .NET:

1. **`List<T>.Contains()` vs `HashSet<T>.Contains()`** — Comparing lookup performance and time complexity through a practical C# benchmark.
2. **`yield return` and `yield break`** — Explaining iterator execution, lazy evaluation, and the implications of repeated enumeration.
3. **`Span<T>`** — Exploring memory-efficient access to sections of arrays and strings, including an important limitation.
4. **Extension Members in C# 14** — Exploring the new extension member syntax, extension properties, and static extension members.

The corresponding post details and links are maintained in `LinkedIn/linked.md`.

## Notes and Assumptions

- The repository is organized into separate directories according to the assignment structure.
- Each refactoring section maintains its own files and project structure.
- Written explanations and answers are provided in the relevant Markdown files.
- Console applications are used to demonstrate and test the implemented functionality where required.
- The solutions follow the assignment requirements and document relevant design decisions and assumptions.
- Generated build directories such as `bin/` and `obj/` are excluded from Git tracking through `.gitignore`.

