using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorClass
{
    public class Class1
    {



        public double operation(List<double> nums, List<char> operands)
        {
            double result = nums[0]; 
           

            for (int i = 0; i < operands.Count-1; i++)
            {
               result = numberOperations(result,nums[i+1], operands[i]);
                    
            }//end for

            return result;
        }//end method

        private double numberOperations(double num1, double num2, char operand)
        {
            double total = num1;
            switch (operand)
            {
                case '+':

                   total += num2;
                   break;

                case '-':

                   total -= num2;
                   break;

            }//end switch

            return total;
        }

        
    }
}