using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentadministrasjon
{
    internal class Main
    {
        public Administrator administrator = new Administrator();
        bool isChoosing = true;

        public void StartUpMenu()
        {
            administrator.AddGrades();
            while (isChoosing)
            {
                Console.WriteLine("Velkommen til studentportalen");
                Console.WriteLine("[1]Se alle studenter" +
                                  "\n[2]Se alle fag" +
                                  "\n[3]Se alle karakterer");
                var userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        Console.Clear();
                        administrator.PrintStudents();
                        break;
                    case "2":
                        Console.Clear();
                        administrator.PrintCourses();
                        break;
                    case "3":
                        Console.Clear();
                        administrator.PrintGrades();
                        break;
                }
            }
        }
    }
}
