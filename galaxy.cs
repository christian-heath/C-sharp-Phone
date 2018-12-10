using System;

namespace Phone
{
    public class Galaxy : Phone, IRingable
    {
        public Galaxy(string versionNumber, int batteryPercentage, string carrier, string ringTone) : base(versionNumber, batteryPercentage, carrier, ringTone) { }
        public string Ring()
        {
            string returnRing = $"....{this.ringTone}....";
            return returnRing;
        }

        public string Unlock()
        {
            string returnUnlock = $"Galaxy {this.versionNumber} unlocked with passcode.";
            return returnUnlock;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("#######################");
            Console.WriteLine($"Galaxy {this.versionNumber}");
            Console.WriteLine($"Battery Percentage: {this.batteryPercentage}");
            Console.WriteLine($"Carrier: {this.carrier}");
            Console.WriteLine($"Ring Tone: {this.ringTone}");
            Console.WriteLine("#######################");
        }
    }

}