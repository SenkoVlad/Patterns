using Patterns.Structural_Design_Patterns.Bridge.Abstractions;
using Patterns.Structural_Design_Patterns.Bridge.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.App.Console.Patterns
{
    class AppBridge
    {
        public static void Test()
        {
            TV tv = new TV();
            Remote remote = new Remote(tv);
            remote.ChannelDown();
            remote.ChannelUp();
            remote.SoundDown();
            remote.SoundUp();
            remote.TogglePower();

            Radio radio = new Radio();
            Remote remote2 = new Remote(radio);

            remote2.ChannelDown();
            remote2.ChannelUp();
            remote2.SoundDown();
            remote2.SoundUp();
            remote2.TogglePower();

            SuperRemote remote3 = new SuperRemote(radio);

            remote3.ChannelDown();
            remote3.ChannelUp();
            remote3.SoundDown();
            remote3.SoundUp();
            remote3.TogglePower();
            remote3.Mute();
        }

    }
}
