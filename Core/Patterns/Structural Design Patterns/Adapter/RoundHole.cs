using Patterns.Structural_Design_Patterns.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural_Design_Patterns.Addapter
{
    public class RoundHole
    {
        protected int radius;
        public RoundHole(int radius)
        {
            this.radius = radius;
        }

        public int getRadius()
        {
            return radius;
        }

        public bool Fits(IRound peg)
        {
            return radius >= peg.getRadius();
        }
    }
}
