using System;
using System.Collections.Generic;

namespace G_NET_84_ADV03
{
    internal class Exercise01
    {
        #region Exercise01

        public static void Run()
        {
            Console.WriteLine(
                "==================== Exercise 01 : Student Grade Manager ===================="
            );

            List<int> Grades = [85, 92, 78, 95, 88, 70, 100, 65];

            Console.WriteLine("Grades:");
            foreach (int grade in Grades)
            {
                Console.WriteLine(grade);
            }

            Console.WriteLine($"Count:{Grades.Count}");
            Console.WriteLine($"First Grade:{Grades[0]}");
            Console.WriteLine($"Last Grade:{Grades[^1]}");

            Grades.Sort();

            Console.WriteLine("Grades After Sort(Ascending):");
            foreach (int grade in Grades)
            {
                Console.WriteLine(grade);
            }

            int FirstAbove90 = Grades.Find(g => g > 90);

            Console.WriteLine(
                $"First Grade Above 90:{FirstAbove90}"
            );

            List<int> FailingGrades = Grades.FindAll(g => g < 75);

            Console.WriteLine("Failing Grades(<75):");
            foreach (int grade in FailingGrades)
            {
                Console.WriteLine(grade);
            }

            Grades.RemoveAll(g => g < 75);

            Console.WriteLine("Grades After Removing Failing Grades:");

            foreach (int grade in Grades)
            {
                Console.WriteLine(grade);
            }

            bool HasFullMark = Grades.Exists(g => g == 100);

            Console.WriteLine(
                $"Exists(Grade == 100):{HasFullMark}"
            );

            List<string> GradeLabels =
                Grades.ConvertAll(g => $"Grade: {g}");

            Console.WriteLine("Grade Labels:");

            foreach (string label in GradeLabels)
            {
                Console.WriteLine(label);
            }
        }

        #endregion
    }
}