using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorClass
{
    public class Class1
    {

        private double result;

        public void operation(List<double> nums, List<char> operands)
        {
            if (operands.ElementAt(0) == '+')
            {
                result += (nums.ElementAt(0) + nums.ElementAt(0 + 1));
            }//end if

            else if (operands.ElementAt(0) == '-')
            {
                result += (nums.ElementAt(0) - nums.ElementAt(0 + 1));
            }//end else if



            for (int i = 1; i < operands.Count; i++)
            {
                switch (operands.ElementAt(i))
                {
                    case '+':
                        //result += nums.ElementAt(i);
                        result += (nums.ElementAt(i));
                        break;

                    case '-':
                        //result -= nums.ElementAt(i);
                        result -= (nums.ElementAt(i));
                        break;

                    default:
                        break;

                }//end switch
            }//end for
        }//end method

        public double getResult()
        {
            return result;
        }//end getResult



    }
}
