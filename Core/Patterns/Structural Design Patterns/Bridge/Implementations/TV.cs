using System;

namespace Patterns.Structural_Design_Patterns.Bridge.Implementations
{
    public class TV : IDevice
    {
        private int channel;
        private int sound;
        private bool enable;
        public TV()
        {
            this.enable = false;
            this.channel = 1;
            this.sound = 5;
        }

        public void Disable()
        {
            this.enable = false;
            Console.WriteLine($"TV Disable() {this.enable}");
        }

        public void Enable()
        {
            this.enable = true;
            Console.WriteLine($"TV Enable() {this.enable}");
        }

        public int GetChannel()
        {
            Console.WriteLine($"TV GetChannel() {this.channel}");
            return channel;
        }

        public int GetSound()
        {
            Console.WriteLine($"TV GetSound() {this.sound}");
            return sound;
        }

        public bool IsEnable()
        {
            Console.WriteLine($"TV IsEnable() {this.enable}");
            return enable;
        }

        public void SetChannel(int channel)
        {
            this.channel = channel;
            Console.WriteLine($"TV SetChannel() {this.channel}");
        }

        public void SetSound(int sound)
        {
            this.sound = sound;
            Console.WriteLine($"TV SetSound() {this.sound}");
        }
    }
}
