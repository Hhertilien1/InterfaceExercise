using System;
using System.Collections.Generic;
using InterfaceExercise;
//TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

//Create 2 Interfaces called IVehicle & ICompany DONE

//Create 3 classes called Car , Truck , & SUV DONE

//In your IVehicle:

/* Create 4 members that Car, Truck, & SUV all have in common.
 * Example: public int NumberOfWheels { get; set; }
 */


//In ICompany: 

/* Create 2 members that are specific to each every company
 * regardless of vehicle type.
 * Example: public string Logo { get; set; }
 */

//In each of your Car, Truck, and SUV classes

/* Create 2 members that are specific to each class
 * Example for Car: public bool HasTrunk { get; set; }
 * Example for SUV: public int NumberOfSeats { get; set; }
 *
 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
 */

//Now, create objects of your 3 classes and give their members values.
//Creatively display and organize their values


Car car1 = new Car();
Truck truck1 = new Truck();
SUV suv1 = new SUV();

car1.ColorofCar = "Blue";
car1.NumberOfDoors = 2;
car1.HasLogo = true;
car1.LogoColor = "Black";
car1.Make = "Kia";
car1.Model = "Forte";
car1.Year = 2020;
car1.Milage = 40000;

truck1.BedSize = 6;
truck1.HasLogo = true;
truck1.HasTruckBed = true;
truck1.LogoColor = "Red";
truck1.Make = "Toyota";
truck1.Model = "Tacoma";
truck1.Year = 2024;
truck1.Milage = 20000;

suv1.GasType = "Super";
suv1.HasLogo = true;
suv1.LogoColor = "Green";
suv1.NumberOfSeatRows = 3;
suv1.Make = "Cadillac";
suv1.Model = "Escalade";
suv1.Year = 2021;
suv1.Milage = 75000;


List<IVehicle> Vehicles = new List<IVehicle>();
Vehicles.Add(car1);
Vehicles.Add(truck1);
Vehicles.Add(suv1);



Console.WriteLine($"Our inventory includes:");
foreach (IVehicle vehicle in Vehicles)
{
    Console.WriteLine($"\n\n{vehicle.Make}\n{vehicle.Model}\n{vehicle.Year}\n{vehicle.Milage} miles\n{vehicle.HasLogo}\n{vehicle.LogoColor}");
}




