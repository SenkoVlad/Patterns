using Patterns.Structural_Design_Patterns.Addapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.App.Console.Patterns
{
    public class AppAdapter
    {
        public static void Test()
        {
            RoundHole hole = new RoundHole(5);
            RoundPeg peg = new RoundPeg(5);

            System.Console.WriteLine(hole.Fits(peg));

            SquarePeg smallSquare = new SquarePeg(5);
            SquarePeg largeSquare = new SquarePeg(10);

            //System.Console.WriteLine(hole.Fits(smallSquare));

            SquarePegAdapter smallSquareAdapter = new SquarePegAdapter(smallSquare);
            SquarePegAdapter largeSquareAdapter = new SquarePegAdapter(largeSquare);

            System.Console.WriteLine(hole.Fits(smallSquareAdapter));
            System.Console.WriteLine(hole.Fits(largeSquareAdapter));

        }
    }
}
