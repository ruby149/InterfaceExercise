using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            var car = new Car();
            car.Reverse();
            car.Park();
            car.TurnOn();
            Console.WriteLine();
            var Truck = new Truck();
            Truck.Reverse();
            Truck.Park();
            Truck.TurnOn();
            Console.WriteLine();

            var SUV = new SUV();
            SUV.Reverse();
            SUV.Park();
            SUV.TurnOn();
            Console.WriteLine();

            Console.WriteLine($"it is pretty  {car.IsSmall} not really meant for moving big items.It does come with {car.doors} doors,and {car.wheels} wheels.It is {car.ItDrives} that it drives and {car.work} it does work.");

            Console.WriteLine($"the truck is big : {Truck.IsBig}");

            var newList = new List<ICompany>();
            newList.Add(car);
            newList.Add(Truck);
            newList.Add(SUV);
            foreach(var item in newList)
            {
                Console.WriteLine($"{item.HasWorkers} they also have workers on site and remotely, and their logo is {item.Logo}");
            }
        }
    }
}
