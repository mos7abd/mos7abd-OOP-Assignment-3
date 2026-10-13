using GenericsLab.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsLab.Stores
{
    // Step 4: Replaced by Store<Course>.
    // Kept for reference to show the design before introducing generics.
    public class CourseStore
    {
        private readonly List<Course> _courses = new();

        // Add: Add a course to the store.
        public void Add(Course course)
        {
            _courses.Add(course);
        }

        // GetById: Return the course with the specified ID, or null if not found.
        public Course? GetById(int id)
        {
            foreach (var course in _courses)
            {
                if (course.Id == id)
                    return course;
            }

            return null;
        }

        // GetAll: Return all courses.
        public List<Course> GetAll()
        {
            return _courses;
        }

        // Remove: Remove a course by its ID.
        public void Remove(int id)
        {
            var course = GetById(id);

            if (course is not null)
                _courses.Remove(course);
        }
    }

}
