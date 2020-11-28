using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integral.Classes
{
    public class RectangleCalculator : ICalculator
    {
        public double Calculate(double a, double b, int n, Func<double, double> f)
        {
            if (n <= 0)
            {
                Exception ex = new ArgumentException("Некорректное значение разбиений");
                throw ex;
            }
            double h = (b - a) / n;
            double s = 0;
            a += h / 2;//Средние прямоугольники
            for(int i = 0; i<n; i++)
            {
                s += f(a + h * i);
            }
            return h*s;
        }
        public double CalculateParalel(double a, double b, int n, Func<double, double> f)
        {
            if (n <= 0)
            {
                Exception ex = new ArgumentException("Некорректное значение разбиений");
                throw ex;
            }
            double h = (b - a) / n;
            double s = 0;
            a += h / 2;//Средние прямоугольники
            object k = new object();
            Parallel.For(0, n, () => 0.0,
                (i, state, localtotal) =>
                localtotal + f(a + h * i),
                localtotal => { lock (k) s += localtotal; });
            return h * s;
        }
    }
}
