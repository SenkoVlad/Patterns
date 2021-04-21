using Patterns.Structural_Design_Patterns.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural_Design_Patterns.Addapter
{
    public class RoundPeg : IRound
    {
        private int radius;
        public RoundPeg(int radius)
        {
            this.radius = radius;
        }
        public double getRadius()
        {
            return radius;
        }
    }
}
