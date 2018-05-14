using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFunc
{
    public class Factorial
    {
        public double Fact(double number)
        {
            double sumFact = 1;
            if (number > 0)
            {
                for (int i = 1; i < number; i++)
                {
                    sumFact *= i;
                }
            }
            else
            {
                throw new ArgumentException("Invalid count!");
            }

            return sumFact;
        }
    }

    public class Graduation
    {
        public double Grad (double number, double grad)
        {
            double num = 1;
            if (number > 0 || grad > 0)
            {
                for (int i = 0; i < grad; i++)
                {
                    num *= number;
                }
            }
            else
            {
                throw new ArgumentException("Invalid arguments!");
            }

            return num;
        }
    }
}
