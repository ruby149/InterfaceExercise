using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck :IVehicle,ICompany
    {
        public Truck()
        { }
        public string HasTrunkBed { get; set; } = "yes";
        public string IsBig { get; set; } = "yes";
        public int doors { get; set; } = 4;
        public int wheels { get; set; } = 4;
        public bool ItDrives { get; set; } = true;
        public string work { get; set; } = "yes";
        public string Logo { get; set; } = "Chevy";
        public string HasWorkers { get; set; } = "yes";

        public void Reverse()
        {
            Console.WriteLine($"Truck is reversing and about to hit the car");
        }
        public void Park()
        {
            Console.WriteLine($"Truck is now parked in the middle of the street");
        }
        public void TurnOn()
        {
            Console.WriteLine($"Truck is now turnon but the engine light is on");
        }


    }
}
