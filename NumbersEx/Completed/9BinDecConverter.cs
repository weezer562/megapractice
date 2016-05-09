using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersEx
{
    class Binary Converter
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Welcome to the Binary Convertor\n" + 
                              "1. Binary to Decimal\n" + 
                              "2. Decimal to Binary\n" + 
                              "Please choose one of the options above: ");
                int answer = Convert.ToInt16(Console.ReadLine());

                string stringNumber;
                int decimalNumber;

                switch (answer)
                {
                    case 1:
                        Console.Write("\nEnter your number in Binary: ");
                        stringNumber = Console.ReadLine();
                        binaryToDecimal(stringNumber);
                        break;
                    case 2:
                        Console.Write("\nEnter your number in Decimal: ");
                        decimalNumber = Convert.ToInt32(Console.ReadLine());
                        decimalToBinary(decimalNumber);
                        break;
                    default:
                        throw new Exception("Not a valid Option");
                }


            } while (true);

        }

        static void binaryToDecimal(string binaryNumber)
        {
            double decimalNumber = 0;
            double power = 0.0;

            //split binary number into an array
            var binaryArray = binaryNumber.ToString().ToArray();
            
            //reverse array so that we can parse from 2^0 first
            Array.Reverse(binaryArray);

            //Parses char array and adds correct amount to total
            foreach (char character in binaryArray)
            {
                if (character == '1')
                {
                    decimalNumber += Math.Pow(2, power);
                }

                power++;
            }

            Console.Write("\nYour Binary Number {0} converted to Decimal is {1} \n\n",binaryNumber,decimalNumber);
        }

        static void decimalToBinary(int decimalNumber)
        {
            int remainder;
            int displayDecimal = decimalNumber;
            List<int> binaryList = new List<int>();

            while (decimalNumber > 1)
            {
                remainder = decimalNumber % 2;
                binaryList.Add(remainder);
                decimalNumber = decimalNumber/2;
            }

            //adding final 1 to list, highest value of any binary number
            if (decimalNumber != 0)
            {
                binaryList.Add(1);
            }
            else
            {
                binaryList.Add(0);
            }
           

            //reversing list
            binaryList.Reverse();

            //make list into string
            string binaryString = string.Join("",binaryList.ToArray());

            //foreach(int value in binaryList)
            //{
            //    Console.Write(value);
            //}
            Console.Write("\nYour decimal number {0} is {1} in binary.\n\n", displayDecimal, binaryString);

        }

    }
}
