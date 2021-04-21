using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural_Design_Patterns.Addapter
{
    public class SquarePeg
    {
        private int width;
        public SquarePeg(int width)
        {
            this.width = width;
        }
        public int getWigth()
        {
            return width;
        }
    }
}
