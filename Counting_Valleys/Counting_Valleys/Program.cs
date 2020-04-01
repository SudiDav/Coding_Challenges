using System;
using System.IO;
using System.Linq;

namespace Counting_Valleys
{
    class Program
    {
        // Complete the countingValleys function below.
        // I added my solution below
        static int countingValleys(int n, string s)
        {
            int level = 0;
            int valleyCount = 0;
            Array numberOfSteps = s.ToArray();
            foreach (char step in numberOfSteps)
            {
                if (step == 'D')
                    level--;
                if (step == 'U')
                {
                    level++;
                    if (level == 0)
                        valleyCount++;
                }
            }
            return valleyCount;
        }
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            string s = Console.ReadLine();

            int result = countingValleys(n, s);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
 }

