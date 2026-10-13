
using GenericsLab.Extensions;
using GenericsLab.Models;
using GenericsLab.Stores;

#region Step 1 - A Store for Students

//var store = new StudentStore();

//// Test 1: Add students
//store.Add(new Student { Id = 1, Name = "Ahmed" });
//store.Add(new Student { Id = 2, Name = "Mohamed" });
//store.Add(new Student { Id = 3, Name = "Mahmoud" });

//// Test 2: GetById - student exists
//var student = store.GetById(2);
//Console.WriteLine($"Found: {student?.Name ?? "null"}");

//// Test 3: GetById - student does not exist
//var missingStudent = store.GetById(99);
//Console.WriteLine($"Missing: {missingStudent?.Name ?? "null"}");

//// Test 4: GetAll - display all students
//Console.WriteLine("All students:");

//foreach (var item in store.GetAll())
//{
//    Console.WriteLine($"{item.Id}: {item.Name}");
//}

//// Test 5: Remove a student
//store.Remove(2);

//Console.WriteLine("After removing student 2:");

//foreach (var item in store.GetAll())
//{
//    Console.WriteLine($"{item.Id}: {item.Name}");
//}

#endregion


#region Step 2 - A Store for Courses

//var courseStore = new CourseStore();

//// Test 1: Add courses
//courseStore.Add(new Course { Id = 1, Title = "C# Basics", Price = 500m });
//courseStore.Add(new Course { Id = 2, Title = ".NET Development", Price = 1200m });
//courseStore.Add(new Course { Id = 3, Title = "Database Fundamentals", Price = 800m });

//// Test 2: GetById
//var foundCourse = courseStore.GetById(2);
//Console.WriteLine($"Found course: {foundCourse?.Title ?? "null"}");

//// Test 3: GetById for a missing course
//var missingCourse = courseStore.GetById(99);
//Console.WriteLine($"Missing course: {missingCourse?.Title ?? "null"}");

//// Test 4: GetAll
//Console.WriteLine("All courses:");

//foreach (var course in courseStore.GetAll())
//{
//    Console.WriteLine($"{course.Id}: {course.Title} - {course.Price}");
//}

//// Test 5: Remove
//courseStore.Remove(2);

//Console.WriteLine("After removing course 2:");

//foreach (var course in courseStore.GetAll())
//{
//    Console.WriteLine($"{course.Id}: {course.Title} - {course.Price}");
//}

#endregion


#region Step 4 - Test Generic Store with IHasId

// Test Store<Student>
var genericStudentStore = new Store<Student>();

genericStudentStore.Add(new Student { Id = 101, Name = "Ali" });
genericStudentStore.Add(new Student { Id = 102, Name = "Omar" });

var foundStudent = genericStudentStore.GetById(102);
Console.WriteLine($"Generic Store - Student: {foundStudent?.Name ?? "null"}");

var missingGenericStudent = genericStudentStore.GetById(999);
Console.WriteLine($"Generic Store - Missing Student: {missingGenericStudent?.Name ?? "null"}");

// Test Store<Course>
var genericCourseStore = new Store<Course>();

genericCourseStore.Add(new Course { Id = 201, Title = "C# Advanced", Price = 1500m });
genericCourseStore.Add(new Course { Id = 202, Title = "ASP.NET Core", Price = 2000m });

var foundCourseStep4 = genericCourseStore.GetById(202);
Console.WriteLine($"Generic Store - Course: {foundCourseStep4?.Title ?? "null"}");

// Test Remove
genericStudentStore.Remove(101);
Console.WriteLine($"Students after removing ID 101: {genericStudentStore.GetAll().Count}");

#endregion


#region Step 5 - Test Fast and Safe Store

var step5Store = new Store<Student>();

// Test adding items.
step5Store.Add(new Student { Id = 301, Name = "Ahmed" });
step5Store.Add(new Student { Id = 302, Name = "Omar" });

// Test direct lookup by ID.
 foundStudent = step5Store.GetById(302);
Console.WriteLine($"Found student: {foundStudent?.Name ?? "null"}");

// Test missing ID.
var missingStudent = step5Store.GetById(999);
Console.WriteLine($"Missing student: {missingStudent?.Name ?? "null"}");

// Test duplicate ID.
try
{
    step5Store.Add(new Student { Id = 301, Name = "Ali" });
}
catch (InvalidOperationException ex)
{
    Console.WriteLine($"Duplicate ID error: {ex.Message}");
}

// Test GetAll.
var allStudents = step5Store.GetAll();
Console.WriteLine($"Students count: {allStudents.Count}");

// Test Remove.
step5Store.Remove(301);
Console.WriteLine($"Students count after removal: {step5Store.GetAll().Count}");

#endregion



#region Step 6 - Generic Extension Methods Tests

// Test data
var studentsForPaging = new List<Student>
{
    new Student { Id = 1, Name = "Ahmed" },
    new Student { Id = 2, Name = "Omar" },
    new Student { Id = 3, Name = "Ali" },
    new Student { Id = 4, Name = "Mona" },
    new Student { Id = 5, Name = "Sara" }
};

var coursesForPaging = new List<Course>
{
    new Course { Id = 101, Title = "C#", Price = 1000m },
    new Course { Id = 102, Title = "SQL", Price = 1200m },
    new Course { Id = 103, Title = "ASP.NET Core", Price = 1500m },
    new Course { Id = 104, Title = "Angular", Price = 1800m }
};

// R1: Page<T>
Console.WriteLine("=== R1: Page Students ===");

foreach (var student in studentsForPaging.Page(2, 2))
{
    Console.WriteLine($"{student.Id} - {student.Name}");
}

Console.WriteLine("=== R1: Page Courses ===");

foreach (var course in coursesForPaging.Page(2, 2))
{
    Console.WriteLine($"{course.Id} - {course.Title}");
}

// R1: Invalid page numbers
try
{
    studentsForPaging.Page(0, 2).GetEnumerator().MoveNext();
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine($"Invalid page: {ex.Message}");
}

// R2: FindById<T>
Console.WriteLine("=== R2: FindById ===");

var foundStudent1 = studentsForPaging.FindById(3);
Console.WriteLine($"Found student: {foundStudent1?.Name ?? "null"}");

var missingStudent1 = studentsForPaging.FindById(999);
Console.WriteLine($"Missing student: {missingStudent1?.Name ?? "null"}");

var foundCourse = coursesForPaging.FindById(103);
Console.WriteLine($"Found course: {foundCourse?.Title ?? "null"}");

var missingCourse = coursesForPaging.FindById(999);
Console.WriteLine($"Missing course: {missingCourse?.Title ?? "null"}");

// R3: ToIdDictionary<T>
Console.WriteLine("=== R3: ToIdDictionary ===");

var studentDictionary = studentsForPaging.ToIdDictionary();
Console.WriteLine($"Student dictionary count: {studentDictionary.Count}");
Console.WriteLine($"Student with ID 3: {studentDictionary[3].Name}");

var courseDictionary = coursesForPaging.ToIdDictionary();
Console.WriteLine($"Course dictionary count: {courseDictionary.Count}");
Console.WriteLine($"Course with ID 103: {courseDictionary[103].Title}");

#endregion






