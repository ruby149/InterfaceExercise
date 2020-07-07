using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace InterfaceExercise
{
    public class Car: IVehicle,ICompany
    {
        public Car()
        { }
        public bool HasTruck { get; set; } = true;
        public string IsSmall { get; set; } = "small";
        public int doors { get; set; } = 4;
        public int wheels { get; set; } = 4;
        public bool ItDrives { get; set; } = true;
        public string work { get; set; } = "yes";
        public string Logo { get; set; } = "Ford";
        public string HasWorkers { get; set; } = "yes";

        public void Reverse()
        {
            Console.WriteLine($"car is reversing");
        }
        public void Park()
        {
            Console.WriteLine($"car is now parked");
        }
        public void TurnOn() 
        {
            Console.WriteLine($"car is now turnon");
        }

    }

}
