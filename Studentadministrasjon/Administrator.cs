using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
I administrator klassen har vi:
- Lister for fag
- Lister for studenter
- Lister for karakterer
- AddGrades() - Metode som legger karakterene inn i studentobjektet - kalles i Main
- PrintStudents() - Koblet til Student objektet - kalles i Main
- PrintCourses() - Koblet til Course objektet - kalles i Main
- PrintGrades() - Koblet til Grade objektet - kalles i Main
- AddCourse() - Kan legge til kurs i Course listen - kalles i PrintCourse()
- RandomCourseNumber() - Gir nye kurs en tilfeldig id - kalles i AddCourse()
- PrintStudentInfo() - Viser karakterinfo for en enkelt student - kalles i PrintStudents()
 */


namespace Studentadministrasjon
{
    internal class Administrator
    {
        public List<Student> students;
        public List<Course> courses;
        public List<Grade> grades;
        public Administrator()
        {
            courses = new List<Course>
            {
                new Course(101, "Naturfag", 30),
                new Course(102, "Nynorsk", 20),
                new Course(150, "Matte", 30),
                new Course(185, "Heimkunnskap", 20),
                new Course(115, "Gym", 20),
            };

            students = new List<Student>
            {
                new Student("Turid", 17, "Media og Kommunikasjon", 1010, new List<Course> {courses[0], courses[2], courses[4] }),
                new Student("Bjarte", 17, "Helse og oppvekst", 1011, new List<Course> {courses[1], courses[2], courses[3] }),
            }; 

            grades = new List<Grade>
            {
                new Grade(students[0], courses[0], 5),
                new Grade(students[0], courses[2], 3),
                new Grade(students[0], courses[4], 2),

                new Grade(students[1], courses[1], 6),
                new Grade(students[1], courses[2], 4),
                new Grade(students[1], courses[3], 4),
            };
        }

        public void AddGrades()
        {
            foreach (Grade grade in grades)
            {
                if (grade._student == students[0])
                {
                    students[0]._grades.Add(grade);
                }
                else if (grade._student == students[1])
                {
                    students[1]._grades.Add(grade);
                }
            }
           
        }

        public void PrintStudents()
        {
            int studentIndex = 1;
            Console.WriteLine("Studenter:\n");
            foreach (Student student in students)
            {
                Console.WriteLine($"[{studentIndex++}]");
                student.PrintInfo();
                Console.WriteLine("----------------------");

            }
            Console.WriteLine("Velg hvilken student du ønsker å se på");
            var userInput = Convert.ToInt32(Console.ReadLine()) - 1;
            PrintStudentInfo(userInput);
        }

        public void PrintCourses()
        {
            Console.WriteLine("Fag:\n");
            foreach (Course course in courses)
            {
                course.PrintInfo();
                Console.WriteLine();
            }
            Console.WriteLine("\n[1]Legg til fag\n[2]Tilbake");
            var userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    AddCourse();
                    break;
                case "2":
                    Console.Clear();
                    break;
            }
        }

        public void PrintGrades()
        {
            Console.WriteLine("Karakterer:\n");
            foreach (Grade grade in grades)
            {
                grade.PrintInfo();
                Console.WriteLine();
            }
            Console.ReadKey();
            Console.Clear();
        }

        public void AddCourse()
        {
            Console.Clear();
            Console.Write("Hva heter faget: ");
            var courseName = Console.ReadLine();
            Console.Write("Hvor mange studiepoeng gir det: ");
            var coursePoints = Convert.ToInt32(Console.ReadLine());
            courses.Add(new Course(RandomCourseNumber(), courseName, coursePoints));
            Console.WriteLine($"{courseName} ble lagt til");
            Console.ReadKey();
            Console.Clear();
        }

        public int RandomCourseNumber()
        {
            var randomNumber = new Random();
            int courseNumber = randomNumber.Next(103, 330);
            return courseNumber;
        }

        public void PrintStudentInfo(int userInput)
        {
            Console.Clear();
            Console.WriteLine($"{students[userInput]._name}:\n");
            students[userInput].PrintGradeList();
            Console.ReadKey();
            Console.Clear();
        }




        //DEL 2 AV OPPGAVEN:
        //public void StartUp()
        //{
        //    Console.WriteLine("Students:");
        //    foreach (Student student in students)
        //    {
        //        student.PrintInfo();
        //    }

        //    Console.WriteLine("\nCourses:");
        //    foreach (Course course in courses)
        //    {
        //        course.PrintInfo();
        //    }

        //    Console.WriteLine("\nGrades:");
        //    foreach (Grade grade in grades)
        //    {
        //        grade.PrintInfo();
        //    }

        //}
    }
}
