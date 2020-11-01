using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integral.Classes
{
    public class TrapezoidCalc : ICalculator
    {
        public double Calculate(double a, double b, int n, Func<double, double> f)
        {
            if (n <= 0)
            {
                Exception ex = new ArgumentException("Некорректное значение разбиений");
                throw ex;
            }
            double h = (b - a) / n;
            double s = (f(a) + f(b)) / 2;
            for (int i = 1; i<n; i++)
            {
                s += f(a + h * i);
            }
            return s * h;
        }
    }
}
