using Patterns.Abstract_Factory.Factories.Implemantions;
using Patterns.Abstract_Factory.Factories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Abstract_Factory
{
    public class ApplicationBuilder
    {
        public Application createAppContext(string factoryName)
        {
            if (factoryName == "Win")
                return new Application(new WinFactory());
            else if(factoryName == "Mac")
                return new Application(new MacFactory());

            return new Application(new LinuxFactory());
        }
    }
}
