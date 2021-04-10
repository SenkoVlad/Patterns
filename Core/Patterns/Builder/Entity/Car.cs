using Patterns.Builder.Entity.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Builder.Entity
{
    public class Car
    {
        public IEngine Engine { get; set; }
        public int CountSeats { get; set; }
        public bool GPS { get; set; }
        public bool Tripcomputer { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"Car engine: {Engine.ToString()}" + Environment.NewLine);
            stringBuilder.Append($"Car seats: {CountSeats.ToString()}" + Environment.NewLine);
            stringBuilder.Append($"Car GPS: {GPS.ToString()}" + Environment.NewLine);
            stringBuilder.Append($"Car TripComputer: {Tripcomputer.ToString()}" + Environment.NewLine);

            return stringBuilder.ToString();
        }
    }
}
