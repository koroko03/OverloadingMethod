using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingMethod
{
    public class Numbers
    {
        public int FindMinimum(int number1, int number2)
        {
            number1 = 2;
            return number1 - number2;
        }

        public int FindMinimum(int number1, int number2, float number3)
        {
            return number1 * number2 - (int)number3; 
        }

        public int FindMaximum(int number1, int number2)
        {
            return number1 * number2;
        }

        public int FindMaximum(int number1, int number2, float number3)
        {
            number2 = 3;
            return number1 * (int)number3 / number2;
        }
    }
}
