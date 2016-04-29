using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersEx
{
    class BinDecConverter
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("How much did the item cost? ");
                


            } while (true);

        }

        static void printChange(double changeDue)
        {
            int zero = 0;
            int dollarAmount = (int)changeDue;
      
            int cents = Convert.ToInt32((changeDue - Convert.ToDouble(dollarAmount)) * 100);
            int totalInCents = dollarAmount * 100 + cents;

            if (totalInCents > 25)
            {
                int quarters = totalInCents / 25;
                Console.WriteLine("Quarters: {0}", quarters);
                totalInCents = totalInCents - quarters * 25;
            }
            else
            {
                Console.WriteLine("Quarters: {0}",zero);
            }

            if (totalInCents > 10)
            {
                int dimes = totalInCents / 10;
                Console.WriteLine("Dimes:     {0}", dimes);
                totalInCents = totalInCents - dimes * 10;
            }
            else
            {
                Console.WriteLine("Dimes:     {0}", zero);
            }

            if (totalInCents > 5)
            {
                int nickels = totalInCents / 5;
                Console.WriteLine("Nickels:   {0}", nickels);
                totalInCents = totalInCents - nickels * 5;
            }
            else
            {
                Console.WriteLine("Nickels:   {0}", zero);
            }

            if (totalInCents > 1)
            {
                int pennies = totalInCents / 1;
                Console.WriteLine("Pennies:   {0}\n", pennies);
                totalInCents = totalInCents - pennies * 1;
            }
            else
            {
                Console.WriteLine("Pennies:   {0}\n", zero);
            }

          
        }

    }
}
