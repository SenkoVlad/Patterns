using Patterns.Structural_Design_Patterns.Bridge.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural_Design_Patterns.Bridge.Abstractions
{
    public class Remote
    {
        protected IDevice device;
        public Remote(IDevice device)
        {
            this.device = device;
        }

        public void TogglePower()
        {
            if (device.IsEnable())
                device.Enable();
            device.Disable();
        }

        public void ChannelUp()
        {
            device.SetChannel(device.GetChannel() + 1);
        }
        public void ChannelDown()
        {
            device.SetChannel(device.GetChannel() - 1);
        }
        public void SoundUp()
        {
            device.SetSound(device.GetSound() + 1);
        }
        public void SoundDown()
        {
            device.SetSound(device.GetSound() - 1);
        }
    }
}
