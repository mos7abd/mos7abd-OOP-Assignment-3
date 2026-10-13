## Step 2 — StudentStore vs CourseStore

**Similarities:**
- Both stores use a `List<T>` to store their objects.
- Both provide the same four methods: `Add`, `GetById`, `GetAll`, and `Remove`.
- Both search for objects using their `Id`.
- Both return `null` when an object with the requested ID is not found.
- Both have nearly identical implementations for their methods.

**Differences:**
- `StudentStore` stores `Student` objects, while `CourseStore` stores `Course` objects.
- A `Student` has `Id` and `Name` properties, while a `Course` has `Id`, `Title`, and `Price`.
- Their method parameter and return types differ because they work with different entity types.

**Conclusion:**

The two stores contain duplicated logic. This suggests that we can create one generic `Store<T>` class to handle different entity types and reduce code duplication.

## Step 3 — Why Does GetById Fail to Compile?

**Compiler error:**

text
'T' does not contain a definition for 'Id' and no accessible extension method 'Id' accepting a first argument of type 'T' could be found (are you missing a using directive or an assembly reference?)


**Explanation:**

The generic type parameter `T` can represent any type. The compiler does not know that every type used with `Store<T>` has an `Id` property.

Although both `Student` and `Course` have an `Id` property, this does not guarantee that every possible type `T` has one.

We need to constrain `T` to types that provide an `Id` property. In Step 4, we will introduce the `IHasId` interface and use the `where T : IHasId` constraint to solve this problem.


## Step 7 — Prove It in Main

The `Main` method demonstrates that the generic store and extension methods work as expected. It also verifies that duplicate IDs are rejected and that `Store<string>()` does not compile because `string` does not implement `IHasId`.

## Final Question — Common Name of the Class

The class built in Steps 4 and 5 is a **Generic Repository**, which follows the Repository Pattern.