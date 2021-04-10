using Patterns.Builder.Buliders;
using Patterns.Builder.Buliders.Implementation;
using Patterns.Builder.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.App.Console.Patterns
{
    public class AppBuilder
    {
        private Manual SportCarManual { get; set; }
        private Manual SimpleCarManual { get; set; }

        private Car SportCar { get; set; }
        private Car SimpleCar { get; set; }

        public void MakeSport()
        {
            CarBuilder carBuilder = new CarBuilder();
            ManualBuilder manualBuilder = new ManualBuilder();
            Director director = new Director();

            director.makeSportCar(carBuilder);
            director.makeSportCar(manualBuilder);
            SportCar = carBuilder.GetCar();
            SportCarManual = manualBuilder.GetManual();

            director.makeSimpleCar(carBuilder);
            director.makeSimpleCar(manualBuilder);
            SimpleCar = carBuilder.GetCar();
            SimpleCarManual = manualBuilder.GetManual();
        }

        public void Show()
        {
            System.Console.WriteLine(SportCarManual.ToString());
            System.Console.WriteLine();
            System.Console.WriteLine(SportCar.ToString());

            System.Console.WriteLine("----------------------------------------------------------");

            System.Console.WriteLine(SimpleCarManual.ToString());
            System.Console.WriteLine();
            System.Console.WriteLine(SimpleCar.ToString());

        }
    }
}
