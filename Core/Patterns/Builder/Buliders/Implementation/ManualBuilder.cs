using Patterns.Builder.Buliders.Interfaces;
using Patterns.Builder.Entity;
using Patterns.Builder.Entity.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Builder.Buliders.Implementation
{
    public class ManualBuilder : IBuilder
    {
        private Manual manual;
        public void reset()
        {
            manual = new Manual();
        }

        public void setEngine(IEngine engine)
        {
            manual.EngineManual = $"Engine: {engine.ToString()}";
        }

        public void setGPS(bool existsFlag)
        {
            manual.GPS = $"GPT: {existsFlag}";
        }

        public void setSeats(int countSeats)
        {
            manual.CountSeats = $"Count of seats: {countSeats.ToString()}";
        }

        public void setTripComputer(bool existsFlag)
        {
            manual.Tripcomputer = $"TripComputer: {existsFlag.ToString()}";
        }

        public Manual GetManual()
        {
            return manual;
        }
    }
}
