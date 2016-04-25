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
                //get user input
                Console.Write("Enter number you wish to find all prime factors for: ");
                var number = Convert.ToInt32(Console.ReadLine());

                //if entered number = 1 return 1 as that is the only prime
                if (number == 1)
                {
                    Console.WriteLine("1 is 1 bud. Good try!!");
                    continue;
                }

                //stores list of prime number between 2 and "number"
                List<int> primeList = new List<int>();

                for (int i = 2; i < number; i++)
                {
                    if(Program.isPrime(i))
                    {
                        var toAdd = i;
                        primeList.Add(toAdd);
                    }
                }
                
                List<int> factorsList = new List<int>();
              
                //Run through primeList to check for primes
                for(int i=0; i<primeList.Count;i++)
                {
                   //if prime is larger than number stop loop
                    if (primeList[i] > number)
                    {
                        break;
                    }
                    //Save number if modules == 0
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
