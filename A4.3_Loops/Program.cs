using System;

namespace A4._3_Loops
{
    internal class Program
    {
        static void Main()
        {
            int passes = 0;
            int failures = 0;
            int itemCounter = 1;
            string Continue = y;

            while (Continue = y)
            {
                Console.Write("Enter Item Id or enter invalid response to exit: ");
                int Id = int.Parse(Console.ReadLine());

                if (Id == 1)
                {
                    passes = passes + 1;
                }
                if (Id == 2)
                {
                    passes = passes + 1;
                }
                if (Id == 3)
                {
                    passes = passes + 1;
                }
                    else
                {
                    failures = failures + 1;
                }

                itemCounter = itemCounter + 1;
                    Console.WriteLine("Continue? (Y/N)");
                    Continue = Console.ReadLine();
            }

            //Console.WriteLine($"Passed: {passes}\nFailed: {failures}");

        }
    }
}
