using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentadministrasjon
{
    // Student:
    // Egenskaper: Navn, Alder, Studieprogram, StudentID.
    // Metode: SkrivUtInfo() som skriver ut informasjon om studenten.

    internal class Student
    {
        public string _name { get; private set; }
        public int _age { get; private set; }
        public string _program { get; private set; }
        public int _studentId { get; private set; }

        //Constructor
        private Student(string name, int age, string program, int studentId)
        {
            _name = name;
            _age = age;
            _program = program;
            _studentId = studentId;
        }

        private void PrintInfo()
        {
            Console.WriteLine($"Navn: {_name}" +
                              $"\nAlder: {_age}" +
                              $"\nStudieprogram: {_program}" +
                              $"\nStudentID: {_studentId}");
        }

    }
}
