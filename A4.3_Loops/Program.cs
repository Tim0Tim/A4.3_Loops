using System;

namespace A4._3_Loops
{
    internal class Program
    {
        int item1 = 0;
        int item2 = 0;
        int item3 = 0;
        int item4 = 0;
        //int failures = 0;
        int itemCounter = 1;
        int Continue = 0;
        decimal income;


       public decimal item1Income = double.Parse(item1);
        decimal item2Income;
        decimal item3Income;
        public decimal item4Income =;

        static void Main()
        {
            



            while (Continue <= 99)
            {
                Console.Write("Enter Item Id or enter invalid response to exit: ");
                int Id = int.Parse(Console.ReadLine());

                if (Id == 1)
                {
                    item1 = item1 + 1;
                }
                if (Id == 2)
                {
                    item2 = item2 + 1;
                }
                if (Id == 3)
                {
                    item3 = item3 + 1;
                }
                if (Id == 4)
                {
                    item4 = item4 + 1;
                }
                    else
                {
                    Console.WriteLine("Invalid value");
                }

                itemCounter = itemCounter + 1;
                    Console.WriteLine("Continue? (Y/N)");
                    Continue = int.Parse(Console.ReadLine());
                    
            }

            Console.WriteLine($"Total Items Sold: {itemCounter}\nRevenue earned: {income}");

        }
    }
}
