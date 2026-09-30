
namespace RobotPrototype
{
    public class ServiceRobot : IRobot
    {
        public string ModelName { get; set; }
        public double BatteryCapacity { get; set; }
        public string SoftwareVersion { get; set; }
        public string ServiceTask { get; set; }

        public IRobot Clone()
        {
            return (ServiceRobot)this.MemberwiseClone();
        }

        public void Display()
        {
            Console.WriteLine("----- Service Robot -----");
            Console.WriteLine("Model Name: " + ModelName);
            Console.WriteLine("Battery Capacity: " + BatteryCapacity + " hours");
            Console.WriteLine("Software Version: " + SoftwareVersion);
            Console.WriteLine("Service Task: " + ServiceTask);
            Console.WriteLine();
        }
    }
}
