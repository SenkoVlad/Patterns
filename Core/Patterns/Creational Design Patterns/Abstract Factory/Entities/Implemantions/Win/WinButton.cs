using Patterns.Abstract_Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Abstract_Factory.Implemantions
{
    class WinButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("this is WinButton");
        }
    }
}
