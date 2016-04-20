using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersEx
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {

                var pi = Math.PI;

                Console.Write("How many digits of PI would you like? ");

                var piDigits = Convert.ToInt32(Console.ReadLine());

                double roundedPI = Math.Round(pi, digitCheck(piDigits));

                Console.WriteLine("PI Rounded to " + piDigits + " is: " + roundedPI);

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
