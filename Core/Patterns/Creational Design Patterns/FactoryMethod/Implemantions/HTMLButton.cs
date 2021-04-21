using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.FactoryMethod
{
    class HTMLButton : IButton
    {
        public void onClick()
        {
            Console.WriteLine("HTMLButton onClick()");
        }

        public void render()
        {
            Console.WriteLine("HTMLButton render()");
        }
    }
}
