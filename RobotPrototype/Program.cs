
using System;

namespace RobotPrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ServiceRobot serviceRobot = new ServiceRobot
            {
                ModelName = "SR-100",
                BatteryCapacity = 10,
                SoftwareVersion = "v1.0",
                ServiceTask = "Assisting patients"
            };

            Console.WriteLine("Original Service Robot:");
            serviceRobot.Display();

            
            ServiceRobot clonedServiceRobot =
                (ServiceRobot)serviceRobot.Clone();

            
            clonedServiceRobot.ModelName = "SR-101";
            clonedServiceRobot.BatteryCapacity = 15;
            clonedServiceRobot.SoftwareVersion = "v2.0";

            Console.WriteLine("Cloned and Customized Service Robot:");
            clonedServiceRobot.Display();


            
            IndustrialRobot industrialRobot = new IndustrialRobot
            {
                ModelName = "IR-200",
                BatteryCapacity = 12,
                SoftwareVersion = "v1.5",
                IndustrialTask = "Welding"
            };

            Console.WriteLine("Original Industrial Robot:");
            industrialRobot.Display();

            
            IndustrialRobot clonedIndustrialRobot =
                (IndustrialRobot)industrialRobot.Clone();

            
            clonedIndustrialRobot.ModelName = "IR-201";
            clonedIndustrialRobot.BatteryCapacity = 18;
            clonedIndustrialRobot.SoftwareVersion = "v2.0";

            Console.WriteLine("Cloned and Customized Industrial Robot:");
            clonedIndustrialRobot.Display();


            
            EntertainmentRobot entertainmentRobot = new EntertainmentRobot
            {
                ModelName = "ER-300",
                BatteryCapacity = 8,
                SoftwareVersion = "v1.2",
                EntertainmentFeature = "Dancing and Talking"
            };

            Console.WriteLine("Original Entertainment Robot:");
            entertainmentRobot.Display();

            
            EntertainmentRobot clonedEntertainmentRobot =
                (EntertainmentRobot)entertainmentRobot.Clone();

            
            clonedEntertainmentRobot.ModelName = "ER-301";
            clonedEntertainmentRobot.BatteryCapacity = 12;
            clonedEntertainmentRobot.SoftwareVersion = "v2.0";

            Console.WriteLine("Cloned and Customized Entertainment Robot:");
            clonedEntertainmentRobot.Display();


            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

