using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
   public interface IVehicle
    {
        public int doors { get; set; }
        public int wheels { get; set; }
        public bool ItDrives { get; set; }
        public string work { get; set; }

        public void Reverse();
        public void Park();
        public void TurnOn();
    }
}
