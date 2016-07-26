using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorClass;

namespace SimpleCalculator
{
    class Program
    {


        static void Main(string[] args)
        {
            execute();

        }//end main

        public static void execute()
        {

            List<double> numbers = new List<double>();
            List<char> operators = new List<char>();
            


            //declare object
            var calc = new Class1();

            do
            {
                //get first num
                Console.WriteLine("Enter your num: ");
                numbers.Add(double.Parse(Console.ReadLine()));

                //get operand
                Console.WriteLine("Enter the operand: ");
                operators.Add(Convert.ToChar(Console.ReadLine()));


            } while (!operators.Contains('='));

          double result = calc.operation(numbers, operators);

            Console.WriteLine("Result is: " + result);
        }//end execute
    }
}