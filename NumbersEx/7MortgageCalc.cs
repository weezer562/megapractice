using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersEx
{
    class MortgageCalculator
    {
        static void Main(string[] args)
        {
            int term;
            int interval;
            double interest;


            do
            {
                Console.Write("Enter the Floor Width: ");
                floorWidth = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the Floor Length: ");
                floorLength = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the Tile Width: ");
                tileWidth = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the Tile Length: ");
                tileLength = Convert.ToDouble(Console.ReadLine());

                Console.Write("How much does each tile cost?");
                tileCost = Convert.ToDouble(Console.ReadLine());

                floorArea = floorWidth * floorLength;
                tileArea = tileWidth * tileWidth;

                var totalTilesNeeded = Convert.ToInt32(floorArea / tileArea) + 1; // Add one to account for percentage
                var totalTileCost = totalTilesNeeded * tileCost;
                Console.WriteLine("Total Cost for {0} tiles is ${1}",totalTilesNeeded,totalTileCost);

            } while (true);

        }
        /// <summary>
        /// Checks number of digits return max 15 is >=14, else returns desired digits
        /// </summary>
        /// <param name="digits"></param>
        /// <returns></returns>
        public static int digitCheck(int digits)
        {
            if (digits >= 14)
            {
                Console.WriteLine("Max digits are 15. Will return 15 decimal spaces.");
                return 15;
            }
            else
            {
                return digits;
            }
        }
    }
}
