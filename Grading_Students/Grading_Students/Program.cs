using System;
using System.Collections.Generic;
using System.IO;

namespace Grading_Students
{
    class Program
    {

        /*
         * Complete the 'gradingStudents' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts INTEGER_ARRAY grades as parameter.
         */

        public static List<int> gradingStudents(List<int> grades)
        {
            for (int i = 0; i < grades.Count; i++)
            {
                var max = grades[i];
                if (max >= 38)
                {
                    var mod = 5 - (max % 5);
                    if (mod < 3)
                        grades[i] = max + mod;
                }
            }

            return grades;
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> grades = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }

            List<int> program = Program.gradingStudents(grades);

            textWriter.WriteLine(String.Join("\n", program));

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
