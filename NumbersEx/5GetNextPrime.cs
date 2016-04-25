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
            int startValue = 1;

            do
            {
               
                //stores list of prime number between 2 and "number"
                List<int> primeList = new List<int>();

                //get user input
                Console.Write("Would you like to retrieve a prime number? (y or n) ");
                var answer = Console.ReadLine().ToString();

                //if entered number = 1 return 1 as that is the only prime
                if (answer.ToLower() == "y")
                {
                    Console.WriteLine("Thank you for using the prime return service.  Have a great day!");
                    break;
                }

                if (Program.isPrime(startValue))
                {
                    Console.WriteLine(startValue);
                }

                startValue++;
        
            } while (true);

        }
        //checks if a number is a prime
        static bool isPrime(int num)
        {
            if (num == 2)
            {
                return true;
            }
            if(num % 2 == 0)
            {
                return false;
            }

            for(int i=2; i*i <= num; i += 2)
            {
                if(num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
