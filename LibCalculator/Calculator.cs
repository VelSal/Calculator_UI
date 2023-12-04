using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCalculator
{
    public class Calculator
    {
        public double Add(double nr1, double nr2)
        {
            return nr1 + nr2;
        }
        public double Subtract(double nr1, double nr2)
        {
            return nr1 - nr2;
        }
        public double Multiply(double nr1, double nr2)
        {
            return nr1 * nr2;
        }
        public double Divide(double nr1, double nr2)
        {
            return nr1 / nr2;
        }
    }
}
