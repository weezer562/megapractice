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
                Console.Write("How many digits of the fibonnaci sequence would you like to display? (Max is 30) ");

                var fibDigits = digitCheck(Convert.ToInt32(Console.ReadLine()));

                //creates array of fib sequence up to specified digit count
                int[] fibArray = new int[fibDigits];

                for (int i = 0; i <= fibDigits-1; i++)
                {
                    if (i <= 1)
                    {
                        fibArray[i] = i;
                    }
                    else
                    {
                        fibArray[i] = fibArray[i-1] + fibArray[i - 2];
                    }
                }

                //prints out array
                foreach (int value in fibArray)
                {
                    Console.Write("{0} ", value);
                }

                Console.WriteLine("\n");

            } while (true);

        }
       
        //checks for max number of digits
        public static int digitCheck(int digits)
        {
            if (digits >= 31)
            {
                Console.WriteLine("Max digits are 30. Will return 30 digits total.");
                return 30;
            }
            else
            {
                return digits;
            }
        }
    }
}
