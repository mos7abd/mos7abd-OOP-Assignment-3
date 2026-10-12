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