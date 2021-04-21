using Patterns.Builder.Buliders.Interfaces;
using Patterns.Builder.Entity.Implementation;

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
