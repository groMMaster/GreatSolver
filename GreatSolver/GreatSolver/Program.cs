using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatSolver
{
    class Program
    {
        public static void Main()
        {
            var s = new RootStandard(new double[] { 1, 2 });
            var a = new RootAny();
            var d = new RootEmpty();
        }
    }
}
