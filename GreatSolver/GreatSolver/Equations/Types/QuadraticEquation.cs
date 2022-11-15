using System;
using System.Collections.Generic;
using System.Text;

namespace GreatSolver
{
    public class QuadraticEquation : IEquation
    {
        private double a;
        private double b;
        private double c;


        public QuadraticEquation(double a, double b, double c)
        {
            this.a = a;
            if (a == 0) throw new ArgumentException("Equation should be quadratic");
            this.b = b;
            this.c = c;
        }

        public Roots GetRoots()
        {
            var discriminant = b * b - 4 * a * c;

            if (discriminant < 0)
                return new Roots();

            if (discriminant == 0)
                return new Roots(-b / (2 * a));

            var x1 = (-b - Math.Sqrt(discriminant)) / 2 * a;
            var x2 = (-b + Math.Sqrt(discriminant)) / 2 * a;
            return new Roots(x1, x2);
        }
    }
}