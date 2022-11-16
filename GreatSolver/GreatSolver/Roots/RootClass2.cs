using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatSolver
{
    public struct RootsT
    {
        public RootTypes Type { get; }
        public double[] Value { get; }
        public RootsT(RootTypes type, params double[] value)
        {
            Type = type;
            Value = null;
        }

        public int Count() => Value.Length;

        public override string ToString()
        {
            if (Type == RootTypes.Any) return "X - любое";
            if (Type == RootTypes.Empty) return "Нет корней";

            int i = 1;
            return String.Join("; ", Value.Select(x => "X" + (i++).ToString() + " = " + x.ToString()).ToArray());
        }
    }

    public enum RootTypes
    {
        Standard,
        Any,
        Empty
    }
}
