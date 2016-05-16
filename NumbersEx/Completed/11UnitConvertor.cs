using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NumbersEx
{
    class UnitCoverter
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Welcome to the Unit Convertor\n" +
                              "1. Temperature\n" +
                              "2. Currency\n" +
                              "3. Volume\n" + 
                              "Please choose one of the options above: ");
                int answer = Convert.ToInt16(Console.ReadLine());

                switch (answer)
                {
                    case 1:
                        temperatureConvert();
                        break;
                    case 2:
                        currencyConvert();
                        break;
                    case 3:
                        volumeConvert();
                        break;
                    default:
                        break;
                }

            } while (true);

        }
        static void temperatureConvert()
        {
            Console.Write("\nChoose One:\n" +
                "1. Celsius --> Fahrenheit\n" +
                "2. Fahrenheit --> Celsius\n" +
                "Input: ");

            int answer = Convert.ToInt16(Console.ReadLine());

            if (answer == 1)
            {
                Console.Write("Enter your Celsius amount: ");
                double celsius = Convert.ToDouble(Console.ReadLine());
                double fahrenheit = (celsius * 1.8) + 32;

                Console.WriteLine("{0} Celsius in Fahrenheit is: {1}\n", celsius, fahrenheit);
            }

            if (answer == 2)
            {
                Console.Write("Enter your Fahrenheit amount: ");
                double fahrenheit = Convert.ToDouble(Console.ReadLine());
                double celsius = (fahrenheit - 32) / 1.8;

                Console.WriteLine("{0} Fahrenheit in Celsius is: {1}\n", fahrenheit, celsius);
            }
        }

        static void currencyConvert()
        {
            double usdToEuroRate = .86438;
            double euroToUsdRate = 1.1569;

            Console.Write("\nChoose One:\n" +
                "1. USD --> Euro\n" +
                "2. Euro --> USD\n" +
                "Input: ");

            int answer = Convert.ToInt16(Console.ReadLine());

            if (answer == 1)
            {
                Console.Write("Enter your Dollar amount: ");
                double dollars = Convert.ToDouble(Console.ReadLine());
                double euros = dollars * usdToEuroRate;

                Console.WriteLine("${0} USD in Euros is: {1}\n", dollars, euros);
            }

            if (answer == 2)
            {
                Console.Write("Enter your Euro amount: ");
                double euros = Convert.ToDouble(Console.ReadLine());
                double dollars = euros * euroToUsdRate;

                Console.WriteLine("{0} Euro in USD is: {1}\n", euros, dollars);
            }
        }

        static void volumeConvert()
        {
            Console.Write("\nChoose One:\n" +
                "1. Box\n" +
                "2. Cylinder\n" +
                "Input: ");

            int answer = Convert.ToInt16(Console.ReadLine());

            if (answer == 1)
            {
                Console.Write("Enter the length of your Box: ");
                double length = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the width of your Box: ");
                double width = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the height of your Box: ");
                double height = Convert.ToDouble(Console.ReadLine());

                double area = length * width * height;

                Console.WriteLine("The area of your Box is: {0}\n", area);
            }

            if (answer == 2)
            {
                Console.Write("Enter the radius of your cylinder: ");
                double radius = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the height of your cylinder: ");
                double height = Convert.ToDouble(Console.ReadLine());
                
                double area = Math.PI * Math.Pow(radius,2) * height;

                Console.WriteLine("The area of your Cylinder is: {0}\n", area);
            }
        }
    }
}
