using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentadministrasjon
{
    internal class Grade
    {
        public Student _student { get; private set; }
        public Course _course { get; private set; }
        public int _grade { get; private set; }

        public Grade(Student student, Course course, int grade)
        {
            _student = student;
            _course = course;
            _grade = grade;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Student: {_student._name}" +
                              $"\nFag: {_course._courseName}" +
                              $"\nKarakter: {_grade}");
        }
    }
}
