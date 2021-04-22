using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural_Design_Patterns.Bridge.Implementations
{
    public interface IDevice
    {
        public bool IsEnable();
        public void SetChannel(int channel);
        public void SetSound(int sound);
        public int GetSound();
        public int GetChannel();
        public void Disable();
        public void Enable();
    }
}
