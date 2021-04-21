using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Prototype.Prototype
{
    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Rectangle(Rectangle rectangel) : base(rectangel)
        {
            Width = rectangel.Width;
            Height = rectangel.Height;
        }
        public Rectangle()
        {
        }
        public override Shape Clone()
        {
            return new Rectangle(this);
        }
    }
}
    