using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.FactoryMethod
{
    class WindowsButton : IButton
    {
        public void onClick()
        {
            Console.WriteLine("WindowsButton onClick()");
        }

        public void render()
        {
            Console.WriteLine("WindowsButton render()");
        }
    }
}
