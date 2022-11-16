using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatSolver
{
    public abstract class Root
    {
        public Root(double[] values)
        {
            Values = values;
        }
        public double[] Values { get; }
        public abstract override string ToString();
    }

    public class RootAny : Root
    {
        public RootAny() : base(null) { }
        public override string ToString()
        {
            return "X - любое";
        }
    }

    public class RootEmpty : Root
    {
        public RootEmpty() : base(null) { }
        public override string ToString()
        {
            return "Нет корней";
        }
    }

    public class RootStandard : Root
    {
        public RootStandard(double[] values) : base(values) { }
        public override string ToString()
        {
            if (Values.Length == 1) return "X = " + Values[0];

            int i = 1;
            return String.Join("; ", Values.Select(x => "X" + (i++).ToString() + " = " + x.ToString()).ToArray()); ;
        }
    }
}
