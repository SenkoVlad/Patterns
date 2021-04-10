using Patterns.Builder.Entity.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Builder.Entity
{
    public class Manual
    {
        public string EngineManual { get; set; }
        public string CountSeats { get; set; }
        public string GPS { get; set; }
        public string Tripcomputer { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Manual: " + EngineManual + Environment.NewLine);
            stringBuilder.Append("Manual: " + CountSeats + Environment.NewLine);
            stringBuilder.Append("Manual: " + GPS + Environment.NewLine);
            stringBuilder.Append("Manual: " + Tripcomputer + Environment.NewLine);

            return stringBuilder.ToString();
        }
    }
}
