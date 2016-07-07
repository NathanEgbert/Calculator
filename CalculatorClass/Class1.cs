using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorClass
{
    public class Class1
    {



        public double operation(double firstNum, char operand, double secondNum)
        {
            
                double result;

                switch (operand)
                {
                    case '+':
                        result = firstNum + secondNum;
                        break;

                    case '-':
                        result = firstNum - secondNum;
                        break;

                    case '*':
                        result = firstNum * secondNum;
                        break;

                    case '/':
                        result = firstNum / secondNum;
                        break;

                    default:
                        return 0;

                }//end switch



                return result;
            
            }//end method
   


    }
}
