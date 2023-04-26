using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Reflection;

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

            var car = new Car()
            {
                Year = 1994,
                Make = "Mitsubishi",
                Model = "3000GT",
                Cylinders = 6,
                TrunkCapacityCuFt = 11.1,
                IsCrosstrek = false,
                CompanyName = "Mitsubishi Motors",
                Location = "Japan"
            };
            
            var truck  = new Truck()
            {
                Year = 2000,
                Make = "Honda",
                Model = "Ridgeline",
                Cylinders = 6,
                LoadCapacity = 1550,
                HasExtendedCab = false,
                CompanyName = "Honda Motor Company",
                Location = "Japan"
            };

            var suv = new SUV()
            {
                Year = 2023,
                Make = "Chevy",
                Model = "Tahoe",
                Cylinders = 8,
                NumberOfSeats = 9,
                IsMidSize = false,
                CompanyName = "Chevrolet",
                Location = "USA"
            };
            Console.WriteLine("===========================");
            Console.WriteLine("Select your vehicle:");
            Console.WriteLine("===========================");
            Console.WriteLine();
            var vehicles = new List<IVehicle>() { car , truck, suv};
            foreach ( var vehicle in vehicles )
            {

                Console.WriteLine($"{vehicle.Year} {vehicle.Make} {vehicle.Model}");
                Console.WriteLine();
            }
            var userSelection = Console.ReadLine().ToLower();
            if (userSelection == "1994 mitsubishi 3000gt")
            {
                Console.WriteLine($"\n" +
                    $"That vehicle is manufactured by {car.CompanyName} in {car.Location}. It has {car.Cylinders} cylinders and {car.TrunkCapacityCuFt} cubic feet\n" +
                    $"of trunk space\n" +
                    $"Crosstrek: {car.IsCrosstrek}");
            }
            else if (userSelection == "2000 honda ridgeline")
            {
                Console.WriteLine($"\n" +
                    $"That vehicle is manufactured by {truck.CompanyName} in {truck.Location}. It has {truck.Cylinders} cylinders and {truck.LoadCapacity} pounds of\n" +
                    $"load capacity.\n" +
                    $"Extended Cab: {truck.HasExtendedCab}");
            }
            else if (userSelection == "2023 chevy tahoe")
            {
                Console.WriteLine($"\n" +
                    $"That vehicle is manufactured by {suv.CompanyName} in {suv.Location}. It has {suv.Cylinders} cylinders and {suv.NumberOfSeats} seats.\n" +
                    $"Midsize: {suv.IsMidSize}");
            }
            else
            {
                Console.WriteLine("Sorry, it looks like you have a spelling error or that car is no longer in stock please try again");
            }
                   

        }

    }
}
