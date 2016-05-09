using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NumbersEx
{
    class AlarmClock
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("The CurrentTime is: {0}\n", DateTime.Now);
                Console.Write("1. Refresh Time\n2. Add a timer\n3. Set an Alarm\nMake a choice: ");
                
                int response = Convert.ToInt16(Console.ReadLine());

                switch (response)
                {
                    case 1:
                        continue;
                    case 2:
                        addTimer();
                        break;
                    case 3:
                        setAlarm();
                        break;
                    default:
                        Console.WriteLine("Not a valid Option");
                        continue;
                }

            } while (true);

        }
        static void addTimer()
        {
            Console.Write("How long is your timer (in minutes): ");
            double time = Convert.ToDouble(Console.ReadLine());

            for (double i = 0.0; i < time; i += .1) 
            {
                Console.WriteLine(DateTime.Now);
                Console.WriteLine("Countdown: {0}", time);
                System.Threading.Thread.Sleep(1000);
                time -= .1;
            }
        }

        static void setAlarm()
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
