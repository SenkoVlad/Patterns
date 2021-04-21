using Patterns.Structural_Design_Patterns.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural_Design_Patterns.Addapter
{
    public class SquarePegAdapter : IRound
    {
        private SquarePeg SquarePeg;

        public SquarePegAdapter(SquarePeg squarePeg)
        {
            SquarePeg = squarePeg;
        }

        public double getRadius()
        {
            return SquarePeg.getWigth() * Math.Sqrt(2) / 2;
        }

    }
}
