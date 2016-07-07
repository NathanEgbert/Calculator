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
            //variables
            double first;
            double second;
            string input;
            char operand;

            //declare object
            var calc = new Class1();

            do
            {
                //get first num
                Console.WriteLine("Enter your first num: ");
                first = double.Parse(Console.ReadLine());

                //get operand
                Console.WriteLine("Enter the operand: ");
                operand = Convert.ToChar(Console.ReadLine());

                //get second num
                Console.WriteLine("Enter your second num: ");
                second = double.Parse(Console.ReadLine());

                //print results
                Console.WriteLine("Result =  " + calc.operation(first, operand, second));
                Console.WriteLine("Do another:");
                input = Console.ReadLine();


            } while (input.Contains("y"));
        }
    }
}
