
using GenericsLab.Models;
using GenericsLab.Stores;

#region Step 1 - A Store for Students

var store = new StudentStore();

// Test 1: Add students
store.Add(new Student { Id = 1, Name = "Ahmed" });
store.Add(new Student { Id = 2, Name = "Mohamed" });
store.Add(new Student { Id = 3, Name = "Mahmoud" });

// Test 2: GetById - student exists
var student = store.GetById(2);
Console.WriteLine($"Found: {student?.Name ?? "null"}");

// Test 3: GetById - student does not exist
var missingStudent = store.GetById(99);
Console.WriteLine($"Missing: {missingStudent?.Name ?? "null"}");

// Test 4: GetAll - display all students
Console.WriteLine("All students:");

foreach (var item in store.GetAll())
{
    Console.WriteLine($"{item.Id}: {item.Name}");
}

// Test 5: Remove a student
store.Remove(2);

Console.WriteLine("After removing student 2:");

foreach (var item in store.GetAll())
{
    Console.WriteLine($"{item.Id}: {item.Name}");
}

#endregion
