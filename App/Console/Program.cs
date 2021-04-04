using Patterns.FactoryMethod;
using System;

namespace Patterns.App.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            AppFactoryMethod factoryMethod = new AppFactoryMethod("Web");
            IButton button = factoryMethod.init();

            button.render();
            button.onClick();
        }
    }
}
 