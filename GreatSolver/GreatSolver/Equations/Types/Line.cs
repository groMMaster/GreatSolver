using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatSolver
{
    public class Line : IEquation
    {
        public double A;
        public double B;

        public Line(double a, double b)
        {
            A = a;
            B = b;
        }

        public Roots GetRoots()
        {
            if (A == 0)
            {
                if (B == 0) return new Roots(isAny: true);
                return new Roots();
            }

            return new Roots(B / A);
        }
    }
}
