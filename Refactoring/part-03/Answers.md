# Part 03 — answers

---

# Part 03 — answers

---

## BlockedUsers

## BlockedUsers

- Time complexity before: `O(R × B)`, where `R` is the number of requests and `B` is the number of blocked IDs.
- Time (ms) before:`14 ms` with 50,000 blocked IDs and 5,000 requests. Found: `5000`.
- What did you change? Converted `blockedIds` to a `HashSet<int>` once before iterating through the requests. 
This improves lookup performance while preserving the number of blocked requests found.
- Time complexity after: `O(B + R)` on average, including building the hash set.
- Time (ms) after: `1 ms` with 50,000 blocked IDs and 5,000 requests. Found: `5000`.

---

## Students

-What was the problem? `StudentCatalog.GetAllStudents()` created a list containing 1,000,000 student objects
before returning it, even though `Program.cs` printed only the first 3 students and then stopped.
-What did you change? Changed `GetAllStudents()` to return `IEnumerable<Student>` and use `yield return` 
to generate students one at a time. This allows the `foreach` loop to stop after printing the first 3 students without creating the remaining students.