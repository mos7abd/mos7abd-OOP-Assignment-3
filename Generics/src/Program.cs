
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




