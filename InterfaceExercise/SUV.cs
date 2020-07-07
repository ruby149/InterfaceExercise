using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace InterfaceExercise
{
    public class SUV : IVehicle,ICompany
    {
        public SUV()
        { }
        public bool HasCargoHoldSize { get; set; } = true;
        public string OkForFamily { get; set; } = "yes";
        public int doors { get; set; } = 4;
        public int wheels { get; set; } = 4;
        public bool ItDrives { get; set; } = true;
        public string work { get; set; } = "yes";
        public string Logo { get; set; } = "Toyota";
        public string HasWorkers { get; set; } = "yes";

        public void Reverse()
        {
            Console.WriteLine($"SUV is reversing back from the hilltop");
        }
        public void Park()
        {
            Console.WriteLine($"SUV is now parked in the correct parking space");
        }
        public void TurnOn()
        {
            Console.WriteLine($"SUV is now turnon, it does work! Woah!");
        }


    }
}
