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
                Console.Clear();
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
            double minutes = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your requested timer length is {0} minutes", minutes);
            TimeSpan zeroTime = new TimeSpan(0);
            TimeSpan timer = TimeSpan.FromMinutes(minutes);

            while (timer != zeroTime)
            {
                Console.Clear();
                Console.WriteLine(timer);
                timer = timer - TimeSpan.FromSeconds(1);
                System.Threading.Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("TIMER OVER!!!!");
            System.Threading.Thread.Sleep(2000);
        }
        static void setAlarm()
        {
            Console.Clear();
            Console.WriteLine("What time do you want to set your timer for: (format: MM-DD-YYYY HH:MM:SS PM/AM");
            DateTime alarm = Convert.ToDateTime(Console.ReadLine());
           
            System.Threading.Thread.Sleep(1000);
            while (DateTime.Now.AddSeconds(-DateTime.Now.Second) != alarm.AddSeconds(-alarm.Second))
            {
                Console.Clear();
                Console.WriteLine(alarm);
                Console.WriteLine(DateTime.Now);
                System.Threading.Thread.Sleep(1000);
            }

            Console.WriteLine("Wake UP!!!!");
        }

    }
}
