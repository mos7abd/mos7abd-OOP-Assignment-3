using GenericsLab.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsLab.Stores
{
    public class StudentStore
    {
        private readonly List<Student> _students = new();

        public void Add(Student student)
        {
            _students.Add(student);
        }

        public Student? GetById(int id)
        {
            foreach (var student in _students)
            {
                if (student.Id == id)
                    return student;
            }

            return null;
        }

        public List<Student> GetAll()
        {
            return _students;
        }

        public void Remove(int id)
        {
            var student = GetById(id);

            if (student is not null)
                _students.Remove(student);
        }
    }

}
