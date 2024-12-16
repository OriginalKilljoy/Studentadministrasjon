﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentadministrasjon
{
    // Fag:
    // Egenskaper: Fagkode, Fagnavn, Antall Studiepoeng.
    // Metode: SkrivUtInfo() som skriver ut informasjon om faget.

    internal class Course
    {
        public int _courseCode { get; private set; }
        public string _courseName { get; private set; }
        public int _studyPoints { get; private set; }

        private Course(int courseCode, string courseName, int studyPoints)
        {
            _courseCode = courseCode;
            _courseName = courseName;
            _studyPoints = studyPoints;
        }

        private void PrintInfo()
        {
            Console.WriteLine($"Fagkode: {_courseCode}" +
                              $"\nFagnavn: {_courseName}" +
                              $"\nStudiepoeng: {_studyPoints}");
        }
    }
}