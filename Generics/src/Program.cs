
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


#region Step 2 - A Store for Courses

var courseStore = new CourseStore();

// Test 1: Add courses
courseStore.Add(new Course { Id = 1, Title = "C# Basics", Price = 500m });
courseStore.Add(new Course { Id = 2, Title = ".NET Development", Price = 1200m });
courseStore.Add(new Course { Id = 3, Title = "Database Fundamentals", Price = 800m });

// Test 2: GetById
var foundCourse = courseStore.GetById(2);
Console.WriteLine($"Found course: {foundCourse?.Title ?? "null"}");

// Test 3: GetById for a missing course
var missingCourse = courseStore.GetById(99);
Console.WriteLine($"Missing course: {missingCourse?.Title ?? "null"}");

// Test 4: GetAll
Console.WriteLine("All courses:");

foreach (var course in courseStore.GetAll())
{
    Console.WriteLine($"{course.Id}: {course.Title} - {course.Price}");
}

// Test 5: Remove
courseStore.Remove(2);

Console.WriteLine("After removing course 2:");

foreach (var course in courseStore.GetAll())
{
    Console.WriteLine($"{course.Id}: {course.Title} - {course.Price}");
}

#endregion

