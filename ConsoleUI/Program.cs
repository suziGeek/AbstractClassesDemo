﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * DONE Create an abstract class called Vehicle
             * DONE The vehicle class shall have three string properties Year, Make, and Model
             * DONE Set the defaults to something generic in the Vehicle class
             * DONE Vehicle shall have an abstract method called DriveAbstract with no implementation
             * DONE Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * DONE Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * DONE Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * DONE Provide the implementations for the abstract methods
             * DONE Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */

            Car myCar = new Car() {Make = "Chevy", Model = "F150", HasTrunk = false, Year = 2014};


            Motorcycle myMotorcycle = new Motorcycle() { Make = "honda", Model = "CB750", Year = 1985, HasSideCart = false };

            Vehicle Sedan = new Car() { HasTrunk = true };
            Vehicle Coupe = new Car() { Make = "BMW", Year = 1972 };

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            vehicles.Add(Sedan);
            vehicles.Add(Coupe);
            vehicles.Add(myMotorcycle);
            vehicles.Add(myCar);

            foreach (var veh in vehicles)
            {
                Console.WriteLine($"Make:{veh.Make} Model:{veh.Model} Year: {veh.Year}");
            }

            // Call each of the drive methods for one car and one motorcycle

            #endregion   
            myCar.DriveVirtual();
            myMotorcycle.DriveAbstract();
            Console.ReadLine();
        }
    }
}
