using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NumbersEx
{
    class Calculator
    {
        static void Main(string[] args)
        {
            do
            {
                double answer = 0.0;
               
                Console.Write("Calculator, format: number operator number. Currently supports +,-,*,/ \n");
                string input = Console.ReadLine();

                string[] operation = input.Split(new Char[] {'+','-','*','/'});
                
                double firstNumber = Convert.ToDouble(operation[0]);
                double secondNumber = Convert.ToDouble(operation[1]);

                string operand = getOperator(input);
                
                switch (operand)
                {
                    case "+":
                        answer = add(firstNumber, secondNumber);
                        break;
                    case "-":
                        answer = subtract(firstNumber, secondNumber);
                        break;
                    case "*":
                        answer = multiply(firstNumber, secondNumber);
                        break;
                    case "/":
                        answer = divide(firstNumber, secondNumber);
                        break;
                    default:
                        throw new Exception("Wrong operator\n");
                }

                Console.Write(answer + "\n");

            } while (true);

        }
        static string getOperator(string answer)
        {
            if (answer.Contains("+"))
            {
                return "+";
            }
            if (answer.Contains("-"))
            {
                return "-";
            }
            if (answer.Contains("*"))
            {
                return "*";
            }
            if (answer.Contains("/"))
            {
                return "/";
            }

            return "Not a valid Operator";
        }

        static double add(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }

        static double subtract(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }

        static double multiply(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }

        static double divide(double firstNumber, double secondNumber)
        {
            if (secondNumber != -0)
            {
                return firstNumber / secondNumber;
            }
            else
            {
                throw new Exception("Cannot divide by zero");
            }
           
        }

    }
}
