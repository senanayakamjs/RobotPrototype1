
using System;

namespace RobotPrototype
{
    public class EntertainmentRobot : IRobot
    {
        public string ModelName { get; set; }
        public double BatteryCapacity { get; set; }
        public string SoftwareVersion { get; set; }
        public string EntertainmentFeature { get; set; }

        public IRobot Clone()
        {
            return (EntertainmentRobot)this.MemberwiseClone();
        }

        public void Display()
        {
            Console.WriteLine("----- Entertainment Robot -----");
            Console.WriteLine("Model Name: " + ModelName);
            Console.WriteLine("Battery Capacity: " + BatteryCapacity + " hours");
            Console.WriteLine("Software Version: " + SoftwareVersion);
            Console.WriteLine("Entertainment Feature: " + EntertainmentFeature);
            Console.WriteLine();
        }
    }
}

