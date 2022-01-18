using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPO_lab_2
{
    public class Calculator
    {
        public double Multipy(double a, double b)
        {
            var multiplier = new Multiplier();
            return multiplier.Execute(a, b);
        }

        public interface IArithmetic
        {
            double Execute(double a, double b);
        }

        public class Multiplier : IArithmetic
        {
            public double Execute(double a, double b)
            {
                return a * b;
            }
        }
    }
}
