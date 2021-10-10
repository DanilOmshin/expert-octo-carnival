using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smallest
{
    public class num
    {
        double TempA, TempB;
        public num()
        {
            TempA = 0;
            TempB = 0;
        }
        public double Mul(double a, double b, double c)
        {
            if (a > b)
                if (a > c)
                {
                    TempA = b;
                    TempB = c;
                    return b * c;
                }
                else
                {
                    TempA = a;
                    TempB = b;
                    return a * b;
                }
            else if (b > c)
            {
                TempA = a;
                TempB = c;
                return a * c;
            }
            else
            {
                TempA = a;
                TempB = b;
                return a * b;
            }
        }

        public string Get(double a, double b, double c)
        {
            double temp = Mul(a, b, c);
            return TempA + " * " + TempB + " = " + temp;
        }
    }
}
