using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural_Design_Patterns.Bridge.Implementations
{
    public class Radio  : IDevice
    {
        private int channel;
        private int sound;
        private bool enable;
        public Radio()
        {
            this.enable = false;
            this.channel = 1;
            this.sound = 5;
        }

        public void Disable()
        {
            this.enable = false;
            Console.WriteLine($"Radio Disable() {this.enable}");
        }

        public void Enable()
        {
            this.enable = true;
            Console.WriteLine($"Radio Enable() {this.enable}");
        }

        public int GetChannel()
        {
            Console.WriteLine($"Radio GetChannel() {this.channel}");
            return channel;
        }

        public int GetSound()
        {
            Console.WriteLine($"Radio GetSound() {this.sound}");
            return sound;
        }

        public bool IsEnable()
        {
            Console.WriteLine($"Radio IsEnable() {this.enable}");
            return enable;
        }

        public void SetChannel(int channel)
        {
            this.channel = channel;
            Console.WriteLine($"Radio SetChannel() {this.channel}");
        }

        public void SetSound(int sound)
        {
            this.sound = sound;
            Console.WriteLine($"Radio SetSound() {this.sound}");
        }
    }
}
