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
            //Prime starting point, will also store last prime number shown
            int primeLocation = 2;

            do
            {
                //get user input
                Console.Write("To Retrieve a new prime number press Enter, to Quit enter Q and press Enter: ");
                var answer = Console.ReadLine().ToString();

                //breaks out of loop if they enter q
                if (answer.ToLower() == "q")
                {
                    break;
                }

                //hitting enter will enact if statement
                if (answer == "")
                {
                    //Finds next prime number and prints it out. 
                    do
                    {
                        if (Program.isPrime(primeLocation))
                        {
                            Console.WriteLine(primeLocation);
                        }
                        primeLocation++;
                    } while (!isPrime(primeLocation));
                }
               
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
