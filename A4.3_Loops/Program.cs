using System;

namespace A4._3_Loops
{
    internal class Program
    {

        // item1Price = 239.99
        // item2Price = 129.75
        // item3Price = 99.95
        // item4Price = 350.89
        static void Main()
        {
            int Continue = 0;
            double item1 = 0;
            double item2 = 0;
            double item3 = 0;
            double item4 = 0;
            int itemCounter = 0;
            double item1Price = 239.99;
            double item2Price = 129.75;
            double item3Price = 99.95;
            double item4Price = 350.89;
            double item1Income = item1 * item1Price;
            double item2Income = item2 * item2Price;
            double item3Income = item3 * item3Price;
            double item4Income = item4 * item4Price;
           // double employeemon;


            while (Continue <= 99)
            {
                Console.Write("Enter Item Id: ");
                int Id = int.Parse(Console.ReadLine());

                if (Id == 1)
                {
                    item1 = item1 ++;
                    itemCounter = itemCounter++;
                }
                if (Id == 2)
                {
                    item2 = item2++;
                    itemCounter = itemCounter++;
                }
                if (Id == 3)
                {
                    item3 = item3++;
                    itemCounter = itemCounter++;
                }
                if (Id == 4)
                {
                    item4 = item4++;
                    itemCounter = itemCounter++;
                }
                if (Id >=5)
                {
                    Console.WriteLine("Invalid value");
                }

                
                    Console.WriteLine("To add more enter any number less than 100");
                    Continue = int.Parse(Console.ReadLine());
                    
            }
            double income = item1Income + item2Income + item3Income + item4Income;
            double employeemon = 200 + income*0.09;
            Console.WriteLine($"Total Items Sold: {itemCounter}\nRevenue earned: {income:C}");

            Console.WriteLine($"Amount of Item 1 sold: {item1}");
            Console.WriteLine($"Amount of Item 2 sold: {item2}");
            Console.WriteLine($"Amount of Item 3 sold: {item3}");
            Console.WriteLine($"Amount of Item 4 sold: {item4}");
            Console.WriteLine($"Amount employee earned {employeemon}");

        }
    }
}
