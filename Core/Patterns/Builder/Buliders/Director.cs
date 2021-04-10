using Patterns.Builder.Buliders.Implementation;
using Patterns.Builder.Buliders.Interfaces;
using Patterns.Builder.Entity.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Builder.Buliders
{
    public class Director
    {
        public void makeSportCar(IBuilder builder)
        {
            builder.reset();
            builder.setEngine(new SportEngine());
            builder.setGPS(true);
            builder.setSeats(2);
            builder.setTripComputer(true);
        }

        public void makeSimpleCar(IBuilder builder)
        {
            builder.reset();
            builder.setEngine(new SimpleEngine());
            builder.setGPS(true);
            builder.setSeats(4);
            builder.setTripComputer(false);
        }
    }
}
