using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Prototype.Prototype
{
    public class Circle : Shape
    {
        public int Radius { get; set; }
        public Circle(Circle circle) : base(circle)
        {
            Radius = circle.Radius;
        }

        public Circle()
        {

        }
        public override Shape Clone()
        {
            return new Circle(this);
        }
    }
}
