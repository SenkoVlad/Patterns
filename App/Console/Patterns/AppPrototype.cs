using Patterns.Prototype;
using Patterns.Prototype.Prototype;
using System.Collections.Generic;

namespace Patterns.App.Console
{
    class AppPrototype
    {
        public List<Shape> Shapes;

        public AppPrototype()
        {
            Shapes = new List<Shape>();

            Circle circle = new Circle();
            circle.X = 10;
            circle.Y = 10;
            circle.Radius = 20;
            circle.Color = "Red";
            Shapes.Add(circle);

            Rectangle rectangle = new Rectangle();
            rectangle.Width = 10;
            rectangle.Height = 20;
            rectangle.Color = "Black";
            Shapes.Add(rectangle);
        }

        public List<Shape> Business()
        {
            List<Shape> shapes = new List<Shape>();

            foreach (var shape in Shapes)
                shapes.Add(shape.Clone());

            return shapes;
        }
    }
}
