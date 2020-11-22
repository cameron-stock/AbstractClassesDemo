using System;
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


            #region Vehicles

            /*
             *DONE* Create an abstract class called Vehicle
             *DONE* The vehicle class shall have three string properties Year, Make, and Model
             *DONE* Set the defaults to something generic in the Vehicle class
             *DONE* Vehicle shall have an abstract method called DriveAbstract with no implementation
             *DONE* Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             *DONE* Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             *DONE* Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             *DONE* Provide the implementations for the abstract methods
             *DONE* Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            var vehicles = new List<Vehicle>();


            /*
             *DONE* Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             *DONE* - new it up as one of each derived class
             *DONE* Set the properties with object initializer syntax
             */

            Car terrian = new Car() { HasTrunk = true, Make = "GMC", Model = "Terrain", Year = 2019 };
            Motorcycle motorcycle = new Motorcycle() { HasSideCart = true, Make = "Harley", Model = "cool", Year = 2020 };

            Vehicle sedan = new Car() { HasTrunk = false, Make = "Honda", Model = "Civic", Year = 2014 };
            Vehicle sport = new Car() { HasTrunk = true, Make = "Chevy", Model = "Corevette", Year = 2008 };


            vehicles.Add(terrian);
            vehicles.Add(motorcycle);
            vehicles.Add(sedan);
            vehicles.Add(sport);

            foreach (var veh in vehicles)
            {
                Console.WriteLine($"Make {veh.Make} Model {veh.Model} Year {veh.Year}");
                veh.DriveAbstract();
            }

            /*
             *DONE* Add the 4 vehicles to the list
             *DONE* Using a foreach loop iterate over each of the properties
             * 
             *
             */

            // *DONE* Call each of the drive methods for one car and one motorcycle

            #endregion
            Console.ReadLine();
        }
    }
}