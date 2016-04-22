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
                Console.Write("Enter number you wish to find all prime factors for: ");

                var number = Convert.ToInt32(Console.ReadLine());

                //if entered number = 1 return 1 as that is the only prime
                if (number == 1)
                {
                    Console.WriteLine("1 is 1 bud. Good try!!");
                    continue;
                }

                //stores array of first 11 prime numbers
                //int[] primeArray = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37 };
                List<int> primeList = new List<int>();

                for (int i = 2; i <= number; i++)
                {
                    if(Program.isPrime(number))
                    {
                        primeList.Add(i);
                  
                    }
                }

                List<int> factorsList = new List<int>();
              
                //Run through primeArray list to check for primes
                for(int i=0; i<primeList.Count;i++)
                {
                   //if prime is larger than number stop loop
                    if (primeList[i] > number)
                    {
                        break;
                    }
                    //Save number if it divides correctly, restarts loop with modified number
                    if (number % primeList[i] == 0)
                    {
                        factorsList.Add(primeList[i]);
                        number = number / primeList[i];
                        i = -1;
                    }
                }
                //print List of factors
                foreach (int factor in factorsList)
                {
                    Console.Write("{0} ", factor);
                }
                Console.WriteLine("\n");

            } while (true);

        }

        static bool isPrime(int number)
        {
            if (number == 2 || number == 3)
                return true;
            if(number % 2 == 0 || number%3 == 0)
                return false;
            
            var i = 5;
            var w = 2;

            while(i * i <= number){
                if(number % i == 0)
                    return false;

                i += w;
                w = 6 - w;
            }


            return true;
        }
    }
}
