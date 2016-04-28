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
            double loan;


            do
            {
                Console.Write("Enter your Loan Amount: ");
                loan = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter your interest: ");
                interest = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter your term amount in years: ");
                term = Convert.ToInt32(Console.ReadLine());

                Console.Write("Choose your interval 12-Monthly, 52-Weekly, 365-Daily: (Enter 12, 52, or 365) ");
                interval = Convert.ToInt32(Console.ReadLine());

                string intervalString = " ";

                switch (interval)
                {
                    case 12:
                        intervalString = "Monthly";
                        break;
                    case 52:
                        intervalString = "Weekly";
                        break;
                    case 365:
                        intervalString = "Daily";
                        break;
                    default:
                        break;
                }

                double rate = (interest / 100) / interval;
                int payments = term * interval;

                double mortgage = (rate / (1-(1 / Math.Pow((1 + rate), payments)))) * loan;

                Console.WriteLine("\nYour {0} mortgage payment is ${1}\n", intervalString, Math.Round(mortgage,2));

            } while (true);

        }
       
    }
}
