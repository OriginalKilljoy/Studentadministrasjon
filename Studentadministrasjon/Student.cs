using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentadministrasjon
{
    internal class Student
    {

        public string _name { get; private set; }
        public int _age { get; private set; }
        public string _program { get; private set; }
        public int _studentId { get; private set; }

        public List<Course> _courses { get; private set; }
        public List<Grade> _grades { get; private set; } = new List<Grade>();

        public int totalStudyPoints;
        public int totalGrades;
        public double averageGrades;

        //Constructor
        public Student(string name, int age, string program, int studentId, List<Course> courses)
        {
            _name = name;
            _age = age;
            _program = program;
            _studentId = studentId;
            _courses = courses;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Navn: {_name}" +
                              $"\nAlder: {_age}" +
                              $"\nStudieprogram: {_program}" +
                              $"\nStudentID: {_studentId}");
            Console.WriteLine();
        }

        public int TotalStudyPoints()
        {
            
            foreach (var course in _courses)
            {
                totalStudyPoints += course._studyPoints;
            }
            return totalStudyPoints;
        }

        public int TotalGrades() 
        {
            foreach (var grade in _grades)
            {
                totalGrades += grade._grade;
            }
            return totalGrades;
        }

        public double AverageGrades()
        {
            TotalGrades();
            averageGrades = totalGrades / _grades.Count;
            return averageGrades;
        }

        public void PrintGradeList()
        {
            Console.WriteLine("Karakterer:");
            foreach (var grade in _grades)
            {
                Console.WriteLine($"{grade._course._courseName}: {grade._grade}");
            }
            Console.WriteLine();
            TotalStudyPoints();
            AverageGrades();
            Console.WriteLine($"Studiepoeng: {totalStudyPoints}");
            Console.WriteLine($"Gjennomsnittskarakter: {averageGrades}");
        }

        //private void PrintCourseList()
        //{
        //    Console.WriteLine("Fag:");
        //    foreach(var course in _courses)
        //    {
        //        Console.WriteLine(course._courseName);
        //    }
        //}

    }
}
