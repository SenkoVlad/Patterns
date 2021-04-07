﻿using Patterns.Abstract_Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Abstract_Factory.Implemantions
{
    class LinuxButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("this is LinuxButton");
        }
    }
}
