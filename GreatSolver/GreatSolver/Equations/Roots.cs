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

        public override string ToString()
        {
            if (IsAny) return "X - любое";
            if (Value is null) return "Нет корней";

            int i = 1;
            return String.Join("; ", Value.Select(x => "X" + (i++).ToString() + " = " + x.ToString()).ToArray());
        }
    }
}
