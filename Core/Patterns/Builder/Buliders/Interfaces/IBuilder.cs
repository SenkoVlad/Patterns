using Patterns.Builder.Entity.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Builder.Buliders.Interfaces
{
    public interface IBuilder
    {
        void reset();
        void setSeats(int countSeats);
        void setEngine(IEngine engine);
        void setTripComputer(bool existsFlag);
        void setGPS(bool existsFlag);
    }
}
