using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatSolver.Equations
{
    public interface IEquation
    {
        Roots GetRoots();
    }
}
