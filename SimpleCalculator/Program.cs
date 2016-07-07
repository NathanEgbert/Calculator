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
            int first;
            int second;
            char operand;

            //declare object
            var calc = new Class1();

            
            //get first num
            Console.WriteLine("Enter your first int: ");
            first = Int32.Parse(Console.ReadLine());

            //get operand
            Console.WriteLine("Enter the operand: ");
            operand = Convert.ToChar(Console.ReadLine());

            //get second num
            Console.WriteLine("Enter your second int: ");
            second = Int32.Parse(Console.ReadLine());

            //print results
            Console.WriteLine("Result =  " + calc.operation(first, operand, second));
            
        }
    }
}
