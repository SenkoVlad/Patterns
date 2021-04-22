using Patterns.Structural_Design_Patterns.Bridge.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural_Design_Patterns.Bridge.Abstractions
{
    public class SuperRemote : Remote
    {
        public SuperRemote(IDevice device) : base(device)
        {
        }

        public void Mute()
        {
            device.SetSound(0);
        }
    }
}
