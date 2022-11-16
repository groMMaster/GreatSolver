using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatSolver
{
    //Об этом еще подумать
    public struct Roots
    {
        public bool IsAny { get; }
        public double[] Value { get; }
        public Roots(bool isAny)
        {
            IsAny = isAny;
            Value = null;
        }

        public Roots(params double[] value)
        {
            IsAny = false;
            Value = value;
        }
    }
}
