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
    public class CarBuilder : IBuilder
    {
        private Car car;
        public void reset()
        {
            car = new Car();
        }

        public void setEngine(IEngine engine)
        {
            car.Engine = engine;
        }

        public void setGPS(bool existsFlag)
        {
            car.GPS = existsFlag;
        }

        public void setSeats(int countSeats)
        {
            car.CountSeats = countSeats;
        }

        public void setTripComputer(bool existsFlag)
        {
            car.Tripcomputer = existsFlag;
        }

        public Car GetCar()
        {
            return car;
        }
    }
}
