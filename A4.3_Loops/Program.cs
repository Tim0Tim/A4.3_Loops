using System;

namespace A4._3_Loops
{
    internal class Program
    {
        static void Main()
        {
            int passes = 0;
            int failures = 0;
            int studentCounter = 1;

            while (studentCounter <= 10)
            {
                Console.Write("Enter Item Id: ");
                int result = int.Parse(Console.ReadLine());

                if (result == 1)
                {
                    passes = passes + 1;
                }
                else
                {
                    failures = failures + 1;
                }

                studentCounter = studentCounter + 1;
            }

            Console.WriteLine($"Passed: {passes}\nFailed: {failures}");

            if (passes > 8)
            {
                Console.WriteLine("Bonus to instructor!");
            }
        }
    }
}
