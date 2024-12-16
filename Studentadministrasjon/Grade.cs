using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentadministrasjon
{
    // Karakter:
    // Egenskaper: Student (referanse til en Student), Fag (referanse til et Fag), Karakterverdi.
    // Metode: SkrivUtInfo() som skriver ut informasjon om karakteren.

    internal class Grade
    {
        public Student _student { get; private set; }
        public Course _course { get; private set; }
        public int _grade { get; private set; }

        private Grade(Student student, Course course, int grade)
        {
            _student = student;
            _course = course;
            _grade = grade;
        }

        private void PrintInfo()
        {
            Console.WriteLine($"Student: {_student._name}" +
                              $"\nFag: {_course._courseName}" +
                              $"\nKarakter: {_grade}");
        }
    }
}
